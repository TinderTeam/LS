using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using GameProject.model;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using GameProject.Util;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        int i = 0;
        private GameTabel gameTabel =GameTabel.getInstance();     
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            System.Console.WriteLine("ok");
            Clients.All.broadcastMessage(name, message);
        }
        public void Ready(string name, string status)
        {
            // Call the broadcastMessage method to update clients.
            System.Console.WriteLine("ok");
            Clients.All.broadcastMessage(i, name, status);
            i++;
        }

        /// <summary>
        /// 用户就坐
        /// </summary>
        /// <param name="userName"></param>
        public void Sit(string userName)
        {
            GameUser gameUser = gameTabel.addPlayer(userName);
            if (gameUser != null)
            {
                String json = JsonService.getJsonStr(gameUser);
                Clients.All.broadcastMessage("add", json);
            }
            else
            {

                Clients.All.broadcastMessage("msg", userName);
            }
          
        }

        public void Show()
        {
            String json = JsonService.getJsonStr(gameTabel);
            Clients.All.broadcastMessage("show", json);
        }
     
    }
}