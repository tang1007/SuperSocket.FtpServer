using System;
using System.Collections.Generic;
using System.Text;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket.Ftp.FtpService.Command
{
    public class HELP : FtpCommandBase
    {
        #region StringCommandBase<FtpSession> Members

        public override void ExecuteCommand(FtpSession session, StringRequestInfo requestInfo)
        {
            session.Send(FtpCoreResource.NotImplement_502);
        }

        #endregion
    }
}
