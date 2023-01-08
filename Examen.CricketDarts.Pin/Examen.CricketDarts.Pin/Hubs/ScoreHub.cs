using Examen.CricketDarts.Pin.Domain;
using Microsoft.AspNetCore.SignalR;

namespace Examen.CricketDarts.Pin.Hubs;

public class ScoreHub : Hub
{
    public Task SendScore(string player, int throw1, int throw2, int throw3, int score)
    {
        return Clients.All.SendAsync("ReceiveScore",player,throw1,throw2,throw3,score);
    }

    public Task SendPlayer(String name, String nationality)
    {
        return Clients.All.SendAsync("ReceivePlayer", name, nationality);
    }
}