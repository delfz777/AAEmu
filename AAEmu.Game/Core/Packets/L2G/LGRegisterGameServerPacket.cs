﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Login;

namespace AAEmu.Game.Core.Packets.L2G
{
    public class LGRegisterGameServerPacket : LoginPacket
    {
        public LGRegisterGameServerPacket() : base(0x00)
        {
        }

        public override void Read(PacketStream stream)
        {
            var result = stream.ReadByte();
            if (result != 0)
            {
                _log.Error("Error registering on LoginServer");
                Connection.Close(); // TODO or shutdown?
            }
            else
            {
                _log.Info("Successufully registered on LoginServer");
            }
        }
    }
}
