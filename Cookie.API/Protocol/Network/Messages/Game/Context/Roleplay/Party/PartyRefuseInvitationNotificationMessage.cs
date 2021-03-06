﻿using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
    {
        public new const ushort ProtocolId = 5596;

        public PartyRefuseInvitationNotificationMessage(ulong guestId)
        {
            GuestId = guestId;
        }

        public PartyRefuseInvitationNotificationMessage()
        {
        }

        public override ushort MessageID => ProtocolId;
        public ulong GuestId { get; set; }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(GuestId);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            GuestId = reader.ReadVarUhLong();
        }
    }
}