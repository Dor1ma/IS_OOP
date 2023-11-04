using System;
using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.Mocks;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MainTests
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFirstTestData), MemberType = typeof(TestDataGenerator))]
    public void IsReceivedMessageIsUnread(string header, string body, PriorityLevels priorityLevel, MarkingResults expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();
        var topicBuilder = new TopicBuilder();
        string title = "First test topic";
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(addressee)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();

        if (topic.Addressee is not null)
        {
            var user = (User)topic.Addressee.ConcreteAddressee;
            Assert.Equal(expected, user.MarkConcreteAsRead(message));
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSecondTestData), MemberType = typeof(TestDataGenerator))]
    public void IsReceivedMessageIsReadAfterChangingItsStatus(string header, string body, PriorityLevels priorityLevel, MarkingResults expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();
        var topicBuilder = new TopicBuilder();
        string title = "Second test topic";
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(addressee)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();

        if (topic.Addressee is not null)
        {
            var user = (User)topic.Addressee.ConcreteAddressee;
            user.MarkAllAsRead();
            Assert.Equal(expected, user.MarkConcreteAsRead(message));
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetThirdTestData), MemberType = typeof(TestDataGenerator))]
    public void CheckIfMarkingAMessageWhichIsAlreadyReadAsReadReturningACorrespondingError(
        string header,
        string body,
        PriorityLevels priorityLevel,
        MarkingResults expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();
        var topicBuilder = new TopicBuilder();
        string title = "Third test topic";
        User user;
        MarkingResults result;
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(addressee)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();

        if (topic.Addressee is not null)
        {
            user = (User)topic.Addressee.ConcreteAddressee;
            _ = user.MarkAllAsRead();
            result = user.MarkAllAsRead();
            Assert.Equal(expected, result);
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFourthTestData), MemberType = typeof(TestDataGenerator))]
    public void CheckIfSentMessageWhichDoesNotMatchToTheFilterIsNotReceived(
        string header,
        string body,
        PriorityLevels messagePriority,
        PriorityLevels addresseeFilter)
    {
        Message? expected = null;
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(messagePriority)
            .Build();
        var addressee = new MockAddresseeUser();
        var topicBuilder = new TopicBuilder();
        string title = "Fourth test topic";
        var loggerDecorator = new MockDecoratedLogger(addressee, new MockLogger());
        var filterDecorator = new MockDecoratedFilter(loggerDecorator, addresseeFilter);
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(filterDecorator)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();
        MockDecoratedFilter testingFilter;
        MockDecoratedLogger tesingLogger;
        MockLogger mockLogger;
        if (topic.Addressee is not null)
        {
            testingFilter = (MockDecoratedFilter)topic.Addressee;
            tesingLogger = (MockDecoratedLogger)testingFilter.Addressee;
            mockLogger = (MockLogger)tesingLogger.Logger;
            Assert.Equal(mockLogger.Message, expected);
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFifthTestData), MemberType = typeof(TestDataGenerator))]
    public void CheckIfLogIsWrittenIfMessageReceived(
        string header,
        string body,
        PriorityLevels priorityLevel,
        string expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();
        var decoratedAddressee = new MockDecoratedLogger(addressee, new MockLogger());
        var topicBuilder = new TopicBuilder();
        string title = "Fifth test topic";
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(decoratedAddressee)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();

        MockDecoratedLogger testingAddressee;
        MockLogger mockLogger;
        bool result = false;
        if (topic.Addressee is not null)
        {
            testingAddressee = (MockDecoratedLogger)topic.Addressee;
            mockLogger = (MockLogger)testingAddressee.Logger;
            result = expected.Equals(mockLogger.Message?.Body, StringComparison.Ordinal);
        }

        Assert.True(result);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSixthTestData), MemberType = typeof(TestDataGenerator))]
    public void MessengerReceivingItsMessageCheck(
        string header,
        string body,
        PriorityLevels priorityLevel,
        string expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var logger = new MockLogger();
        var addressee = new MockAddresseeMessenger(logger);
        var topicBuilder = new TopicBuilder();
        string title = "Fifth test topic";
        Topic topic = topicBuilder
            .WithTitle(title)
            .WithAddressee(addressee)
            .WithMessage(message)
            .Build();

        topic.SendMessageToAddressee();

        MockAddresseeMessenger mockAddresseeMessenger;
        MockMessenger mockMessenger;
        bool result = false;
        if (topic.Addressee is not null)
        {
            mockAddresseeMessenger = (MockAddresseeMessenger)topic.Addressee;
            mockMessenger = (MockMessenger)mockAddresseeMessenger.ConcreteAddressee;
            Message oneMessageToCheck;
            foreach (Message concreteMessage in mockAddresseeMessenger.ConcreteAddressee.Messages)
            {
                oneMessageToCheck = concreteMessage;
                mockMessenger.ShowText(oneMessageToCheck);
            }

            result = expected.Equals(mockMessenger.ShowingResult, StringComparison.Ordinal);
        }

        Assert.True(result);
    }

    private class TestDataGenerator : IEnumerable<object[]>
    {
        private const string MessageHeader = "I am test header";
        private const string MessageBody = "I am test message body";
        private const PriorityLevels Priority = PriorityLevels.None;
        private const PriorityLevels FourthTestMessagePriority = PriorityLevels.LowLevelPriority;
        private const PriorityLevels FourthTestAddresseeFilter = PriorityLevels.HighLevelPriority;
        private const MarkingResults FirstTestExpected = MarkingResults.Success;
        private const MarkingResults SecondTestExpected = MarkingResults.CannotMarkAsReadThisMessageBecauseItIsAlreadyRead;
        private const MarkingResults ThirdTestExpected = MarkingResults.CannotMarkAsReadThisMessageBecauseItIsAlreadyRead;

        private const string FifthTestExpected = MessageBody;
        private const string SixthTestExpected = $"{MessageBody}" + " MESSENGER";
        public static IEnumerable<object[]> GetFirstTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                Priority,
                FirstTestExpected,
            };
        }

        public static IEnumerable<object[]> GetSecondTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                Priority,
                SecondTestExpected,
            };
        }

        public static IEnumerable<object[]> GetThirdTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                Priority,
                ThirdTestExpected,
            };
        }

        public static IEnumerable<object[]> GetFourthTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                FourthTestMessagePriority,
                FourthTestAddresseeFilter,
            };
        }

        public static IEnumerable<object[]> GetFifthTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                Priority,
                FifthTestExpected,
            };
        }

        public static IEnumerable<object[]> GetSixthTestData()
        {
            yield return new object[]
            {
                MessageHeader,
                MessageBody,
                Priority,
                SixthTestExpected,
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotValidImplementationException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}