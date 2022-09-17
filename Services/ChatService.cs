namespace Eindopdracht.Services;

public interface IChatService
{
    bool CheckForBadWord(Chat input, string ForbiddenWords);
}

public class ChatService : IChatService
{
    // public readonly IChatRepository _chatRepository;

    public ChatService()
    {
        // _chatRepository = chatRepository;
    }

    public bool CheckForBadWord(Chat input, string ForbiddenWords)
    {
        var words = ForbiddenWords;

        bool isBadWord = false;

        if (input.Word.Contains(words))
        {
            isBadWord = true;
        }
        else
        {
            isBadWord = false;
        }

        return isBadWord;
    }
}