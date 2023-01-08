using Examen.CricketDarts.Pin.Domain;
using Microsoft.AspNetCore.SignalR;

namespace Examen.CricketDarts.Pin.Hubs;

public class ScoreHub : Hub
{
    public Task SendScore(Score score)
    {
        return Clients.All.SendAsync("ReceiveScore", score);
    }

    public Task SendPlayer(Player player)
    {
        return Clients.All.SendAsync("ReceivePlayer", player);
    }
}