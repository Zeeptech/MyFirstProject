using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Roles
{
    class Hunter: Entity
    {

        public Attack[] attacks = {
            new Attack(
                "Quick Knock",
                "You deftly pull an arrow from your quiver, notch it onto your bow, and with practiced ease draw and release. The arrow whistles through the air and strikes the enemy with a solid thud!",
                "In your haste, you fumble with your bowstring and the arrow slips from your grasp. The arrow ricochets off a nearby rock, bounces back and hits you square in the forehead! You fall to the ground in a daze, defeated.",
                "With lightning speed, you pull an arrow from your quiver, notch it onto your bow, and draw back the string with such force that it hums like a tuning fork. The arrow flies straight and true, striking the enemy with deadly accuracy. The force of the impact sends the enemy crashing through a nearby wall, leaving a gaping hole in their wake."
            ),
            new Attack(
                "Chameleon Arrow",
                "You carefully aim your bow, pulling back the string with a steady hand. You release the arrow and it disappears from sight, blending seamlessly with its surroundings. The enemy looks around, confused, before you strike from an unexpected angle!",
                "You try to blend in with your surroundings, but instead you turn bright neon green! The enemy spots you immediately and charges at you, weapon at the ready. You panic and flee, but they quickly catch up and slay you in one swift blow.",
                "The arrow vanishes from sight as soon as you release it. The enemy has no idea what's coming as it suddenly reappears, striking them in a vital area. The enemy is caught off-guard, and stumbles back in pain."
            ),
            new Attack(
                "Rain of Arrows",
                "You call upon the spirits of the wind to summon a tempest of arrows upon the enemy. You unleash a flurry of arrows that rain down upon the enemy, striking them with unrelenting force!",
                "You summon the spirits of the wind, but they are in a foul mood. Instead of a tempest of arrows, a tempest of bees swarms around you, stinging you mercilessly. You try to defend yourself, but you are quickly overwhelmed and die a painful death.",
                "You unleash a torrent of arrows that blot out the sky, striking the enemy with a barrage of deadly force. The enemy tries to dodge and weave, but your aim is true and they are struck repeatedly. They fall to their knees, defeated."
            )
        };

    
        public Hunter(string name, string gender, string race) : base(name, gender, race)
        {

        }
    }
}
