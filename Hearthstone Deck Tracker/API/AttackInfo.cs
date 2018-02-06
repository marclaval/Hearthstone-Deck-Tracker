using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;

namespace Hearthstone_Deck_Tracker.API
{
	public class AttackInfo
	{
		public Card Attacker { get; }
		public Card Defender { get; }

		public AttackInfo(Card attacker, Card defender)
		{
			Attacker = attacker;
			Defender = defender;
		}
	}

	public class AttackInfoWithEntity
	{
		public Entity Attacker { get; }
		public Entity Defender { get; }

		public AttackInfoWithEntity(Entity attacker, Entity defender)
		{
			Attacker = attacker;
			Defender = defender;
		}
	}
}
