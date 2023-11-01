using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Addressee;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MainTests
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFirstTestData), MemberType = typeof(TestDataGenerator))]
    public void IsReceivedMessageIsUnread(string header, string body, PriorityLevels priorityLevel, Status expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();

        addressee.Receive(message);

        foreach (Message localMessage in addressee.User.Messages)
        {
            Assert.Equal(expected, localMessage.Status);
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSecondTestData), MemberType = typeof(TestDataGenerator))]
    public void IsReceivedMessageIsReadAfterChangingItsStatus(string header, string body, PriorityLevels priorityLevel, Status expected)
    {
        var messageBuilder = new MessageBuilder();
        Message message = messageBuilder
            .WithHeader(header)
            .WithBody(body)
            .WithPriority(priorityLevel)
            .Build();
        var addressee = new AddresseeUser();

        addressee.Receive(message);

        foreach (Message localMessage in addressee.User.Messages)
        {
            localMessage.MarkAsRead();
            Assert.Equal(expected, localMessage.Status);
        }
    }

    private class TestDataGenerator : IEnumerable<object[]>
    {
        private const string MessageHeader = "I am first test header";
        private const string MessageBody = "I am first test message body";
        private const PriorityLevels Priority = PriorityLevels.None;
        private const Status FirstTestExpected = Status.Unread;
        private const Status SecondTestExpected = Status.Read;
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