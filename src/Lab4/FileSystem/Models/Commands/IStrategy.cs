namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;

public interface IStrategy
{
    void Connect(ref string address, string newValue);
    void Disconnect(ref string address);
    void TreeGoTo(ref string address, string path);
    void TreeList(ref string address, int depth);
    void FileCopy(ref string address, string sourcePath, string destinationPath);
    void FileDelete(ref string address, string path);
    void FileMove(ref string address, string sourcePath, string destinationPath);
    void FileRename(ref string address, string path, string name);
    void FileShow(ref string address, string path, string mode);
}