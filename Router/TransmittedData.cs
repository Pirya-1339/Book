﻿namespace Gamer228.TGBOT.Router;

public class TransmittedData
{
    public State State { get; set; }
    public DataStorage DataStorage { get; }
    public long ChatId { get; }

    public TransmittedData(long chatId)
    {
        ChatId = chatId;
        State = State.WaitingCommandStart;
        DataStorage = new DataStorage();
    }
}