using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Roles
{
    class Warrior: Entity
    {
        public Attack[] attacks = {
            new Attack(
                "Thundering Blow",
                "You raise your weapon high above your head, summoning the power of the gods themselves. You bring your weapon crashing down upon the enemy with thundering force, creating a massive shockwave that shatters the earth!",
                "You raise your weapon high above your head, but you accidentally trip over your own feet and fall flat on your face. Your weapon lands on top of you, and the enemy uses the opportunity to stomp on you until you're nothing but a pile of goo.",
                "You summon the power of the heavens with a mighty shout, and your weapon glows with divine energy. You bring your weapon down upon the enemy with a thunderous crash, creating a massive explosion that leaves the enemy charred and smoldering."
            ),
            new Attack(
                "Charging Bull",
                "You lower your shoulder and charge at the enemy, pushing them back with the force of a runaway bull. ",
                "You lower your shoulder and charge at the enemy, but you trip over a pebble and go tumbling head over heels. The enemy watches in amusement as you crash into a nearby bush and are unable to get up. You die of embarrassment.",
                "Your eyes starts to glow in bright red as you charge at the enemy with all your might, striking them with the force of a charging bull. As if time moved in slow-motion, you can feel every single bone in the enemys body break as your shoulder digs it's way into their chest. The impact sends the enemy flying through the air, crashing into a nearby boulder and shattering it into a million pieces. "
            ),
            new Attack(
                "Whirlwind Slash",
                "You spin around with your weapon held high, striking the enemy with a flurry of quick slashes.",
                "You spin around with your weapon held high, but you lose your balance and fall over. Your weapon flies out of your hand and impales itself in the ground. The enemy laughs at your clumsiness, and you die of embarrassment.",
                "You spin around with your weapon held high, striking the enemy with a whirlwind of deadly slashes. Your weapon moves so fast that it creates a shockwave that knocks the enemy off their feet. The enemy is left disoriented and defeated."
            )
        };
        public Warrior(string name, string gender, string race) : base(name, gender, race)
        {

        }
    }
}
