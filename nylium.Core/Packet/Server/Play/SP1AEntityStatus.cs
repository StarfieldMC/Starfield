using nylium.Core.DataTypes;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x1A, ProtocolState.Play, PacketSide.Server)]
    public class SP1AEntityStatus : NetworkPacket {

        public int EntityId { get; }
        public EntityStatus Status { get; }

        public SP1AEntityStatus(int entityId, EntityStatus status) {
            EntityId = entityId;
            Status = status;

            Byte @byte = new((sbyte) Status);
            @byte.Write(Data);
        }

        // TODO there's so much more shit here
        // https://wiki.vg/Entity_statuses
        public enum EntityStatus : sbyte {

            /// <summary>
            /// Living Entity
            /// <br>Plays the hurt animation and hurt sound</br>
            /// </summary>
            PlayHurtAnimation = 2,

            /// <summary>
            /// Living Entity
            /// <br>Plays the death sound and death animation</br>
            /// </summary>
            PlayDeathAnimation,

            /// <summary>
            /// Living Entity
            /// <br>Swaps the hand items of the entity</br>
            /// </summary>
            SwapHandItems = 55,

            /// <summary>
            /// Player
            /// <br>Marks item use as finished (finished eating, finished drinking, etc)</br>
            /// <br>This status is not required if you want more control on the server side,</br>
            /// <br>this basicly finishes the interaction on the client side to decrease the food quantity, arrow quantity, etc.</br>
            /// <br>But you can trigger these changes manually through other packets or prevent those changes on the client.</br>
            /// <br>Examples:</br>
            /// <br> - Create a 'Infinity Bow' without the first arrow in your inventory constantly changing in quantity.</br>
            /// <br> - Create a custom found that is infinite, and prevent the stack quantity from descreasing.</br>
            /// <br>Note: This works together with the 'Hand data' so this will have to be updated accordingly to 'finish' the interaction manually.</br>
            /// </summary>
            MarkItemUseAsFinished = 9,

            /// <summary>
            /// Player
            /// <br>Enables reduced debug screen information</br>
            /// </summary>
            EnableReducedDebugInfo = 22,
            
            /// <summary>
            /// Player
            /// <br>Disables reduced debug screen information</br>
            /// </summary>
            DisableReducedDebugInfo,

            /// <summary>
            /// Player
            /// <br>Sets op permission level to 0</br>
            /// </summary>
            SetOpLevel0,

            /// <summary>
            /// Player
            /// <br>Sets op permission level to 1</br>
            /// </summary>
            SetOpLevel1,

            /// <summary>
            /// Player
            /// <br>Sets op permission level to 2</br>
            /// </summary>
            SetOpLevel2,

            /// <summary>
            /// Player
            /// <br>Sets op permission level to 3</br>
            /// </summary>
            SetOpLevel3,

            /// <summary>
            /// Player
            /// <br>Sets op permission level to 4</br>
            /// </summary>
            SetOpLevel4
        }
    }
}