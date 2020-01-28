using Akka.Actor;
using Application.UserCases.Tenants.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UserCases.Tenants
{
    public class TenantManagerActor : ReceiveActor
    {
        public TenantManagerActor()
        {
            Receive<AddTenantModel>(command =>
            {
                string a = "";
            });
        }
    }
}
