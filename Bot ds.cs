MainTask(args).ConfigureAwait(false).GetAwaiter().GetResult();

discord = new DiscordClient(new DiscordConfiguration
{
    Token = MTAwMzM1NDM0Njc2OTEwOTAyMg.GBa1_q.JMPOr8dbZFEzJIng9Oz-CFW94d3zXBxjn3FsQI,
    TokenType = TokenType.Bot,
    UseInternalLogHandler = true,
    LogLevel = LogLevel.Debug
});

discord.MEssageCreated += async e =>
{
    string message = e.Massage.Content;
    if (massage.StartWith("&"))
    {
        await e.Massage.RespondAsync("Hello,"+ e.Author.Username);
        await discord.ConnectAsync();
        await Task.Delay(-1);
    }
};