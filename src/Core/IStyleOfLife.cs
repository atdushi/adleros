namespace AdlerOS.Core;

public interface IStyleOfLife
{
    string Name { get; }

    void HandleSocialTask(string taskDescription, ref double inferiorityIndex, ref double socialInterest);
}
