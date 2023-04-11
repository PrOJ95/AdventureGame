using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Scenario
{
    internal class UndeterminedEnd
    {
        static string input;
        static int choice;
        static bool probedGateway = false;
        internal static void beforeBranch()
        {
            Console.WriteLine("\nChapter 1: The Anomaly");
            Console.WriteLine("\nAs you approach the anomaly, tension is high among the crew. \nIt's unlike anything you've ever seen, a swirling vortex of \nenergy that seems to defy all known laws of physics. Your \ninstruments are going haywire, and you can sense the fear \nin your crewmates' eyes. But you've come too far to turn \nback now. \"Steady as she goes,\" you command, gritting your \nteeth as you enter the maelstrom.\r\n\r\nAs you make your way through the chaos, you're buffeted by \npowerful currents and radiation storms. But you press on, \ndriven by a combination of scientific curiosity and a deep \nsense of adventure. Suddenly, your sensors detect a massive \nstructure in the heart of the anomaly - a structure that \nshouldn't be there. \"What are your orders, Captain?\" asks your first \nofficer, her voice unsteady. You weigh your options carefully.");
            beforeBranch_Choice();
            Console.ReadKey();
        }
        internal static void beforeBranch_Choice()
        {
            Console.WriteLine("\r\nDo you:\r\n1) Approach the structure and attempt to make contact?\r\n2) Deploy a probe to gather more data before proceeding?\r\n3) Retreat to a safe distance and observe from afar?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        A1Branch();
                        break;
                    case 2:
                        A2Branch();
                        break;
                    case 3:
                        A3Branch();
                        break;
                    default:
                        Game.InvalidInput("1-3");
                        beforeBranch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-3");
                beforeBranch_Choice();
            }
        }
        internal static void A1Branch()
        {
            Console.WriteLine("\nYou take a deep breath and make your decision. \"Helm, take us in closer. Let's try to establish \ncommunication with whoever or whatever is inside that structure.\" The crew looks at you with a \nmix of fear and anticipation, and you can't help but feel a sense of pride in their bravery.\r\n\r\nAs you near the structure, you can see that it's unlike anything you've ever encountered. Its surface \nis smooth and metallic, and it seems to emit a pulsating energy that hums through the ship's hull. \n\"Captain, we're receiving a transmission,\" says your communications officer. \"It's...not like \nanything I've ever heard before.\"");
            A1Branch_Choice();
        } //approach structure
        internal static void A1Branch_Choice()
        {
            Console.WriteLine("\nDo you:\n1) Attempt to communicate with the structure and decipher its message?\n2) Respond in all known languages, hoping for a response?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        BBranch();
                        break;
                    case 2:
                        CBranch();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        A1Branch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                A1Branch_Choice();
            }
        } //B or C
        internal static void A2Branch()
        {
            Console.WriteLine("\nYou nod to your first officer. \"Deploy a probe,\" you order. \"I want as much data on that structure as we \ncan gather before we make any decisions.\" She nods and turns to relay the order to the crew.\r\n\r\nMinutes later, the probe sends back images and readings that leave you all stunned. The structure is \nenormous, spanning several kilometres in every direction, and it appears to be made of an unknown \nmaterial that defies analysis. But the most shocking discovery is yet to come: the structure is \nemitting a signal, one that seems to be directed specifically at your ship.");
            A2Branch_Choice();
        } //send probe
        internal static void A2Branch_Choice()
        {
            Console.WriteLine("\nDo you:\n1) Attempt to communicate with the structure and decipher its message?\n2) Retreat immediately and observe from afar?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        BBranch();
                        break;
                    case 2:
                        A3Branch();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        A2Branch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                A2Branch_Choice();
            }
        }//B or game over
        internal static void A3Branch()
        {
            Console.WriteLine("\nAs the captain, you decide that discretion is the better part of valour. You order the Odyssey to retreat \nto a safe distance, hoping to observe the anomaly and the mysterious structure from afar. But as \nyou pull away, you hear a deafening roar, and the ship shudders violently. Suddenly, you're caught \nin a vortex of energy, spiralling uncontrollably toward the centre of the anomaly. \"Evasive \nmanoeuvres!\" you shout, but it's too late. The ship is torn apart by the intense gravitational forces, \nand you're swallowed up by the anomaly, never to be seen or heard from again.\r\n\r\nGame over.");
            restartChapter();
        } //game over
        static void restartChapter()
        {
            Console.WriteLine($"\nYou can return to the start of the chapter, or exit the game now.\n1) Return\n2) Exit");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        beforeBranch();
                        break;
                    case 2:
                        Game.exitGame();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        restartChapter();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                restartChapter();
            }
        } //to beforeBranch
        internal static void BBranch()
        {
            Console.WriteLine("\nYou nod at the communications officer. \"Do your best to transcribe it and put it on screen for us all to \nsee.\" The officer gets to work, and after a few tense moments, the transmission is displayed on your \nmain viewscreen. It's a series of complex symbols and sounds that are completely foreign to you.\r\n\r\nBut something about them seems familiar, and you feel a jolt of excitement. \"Wait a minute,\" you say, \nstudying the symbols more closely. \"I think I recognize this. It's a code, a language from an ancient \ncivilization that was thought to be extinct.\"");
            BBranch_Choice();
        } //communicate and decipher
        internal static void BBranch_Choice()
        {
            Console.WriteLine("\nDo you:\r\n\r\n1) Try to decipher the code yourselves?\r\n2) Use your ship's computer to attempt to decode the message?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        B1Branch();
                        break;
                    case 2:
                        B2Branch();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        BBranch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                BBranch_Choice();
            }
        }//B1 or B2
        internal static void B1Branch()
        {
            Console.WriteLine("\n\"I know this language,\" you declare, your eyes scanning the symbols intently. \"Or at least, I know \nenough of it to attempt a translation.\" You begin to decipher the code, slowly at first, but soon \nyou're reading it fluently. The message is fragmented, but it seems to be an invitation to enter the \nstructure.\r\n\r\nWithout hesitation, you order the helm to steer you closer. As you approach, the structure begins to \ntransform before your eyes, shifting and warping into a glowing gateway. It hums with energy, \nand you can feel the power emanating from it.\r\n\r\n\"Captain,\" says your science officer, her voice hushed. \"This is incredible. I believe we've just \ndiscovered a new form of technology - one that could revolutionize space travel as we know it.\"");
            B1Branch_Choice();
        }//decipher manually
        internal static void B1Branch_Choice()
        {
            Console.WriteLine("\nDo you:\r\n\r\n1) Enter the gateway, hoping to uncover the secrets of the ancient civilization?\r\n2) Back away from the structure and observe it?\r\n3) Send a probe through the gateway to gather more data before proceeding?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        DBranch();
                        break;
                    case 2:
                        A3Branch();
                        break;
                    case 3:
                        B1_3Branch();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        B1Branch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                B1Branch_Choice();
            }
        }//D, game over, secret trigger then D
        internal static void B1_3Branch()
        {
            probedGateway = true;
            Console.WriteLine("\nYou decide to err on the side of caution and order your science officer to prepare a probe for entry \ninto the gateway. The probe is equipped with the latest sensors and cameras to gather as much \ndata as possible, while still being small enough to avoid any potential danger.\r\n\r\nAs the probe enters the gateway, you hold your breath, waiting for any signs of danger. But to your \nrelief, the probe emerges on the other side unscathed, transmitting data and images back to your \nship in real-time.\r\n\r\nThe images are unlike anything you've ever seen before. Strange new worlds and civilizations, \nadvanced technology beyond your wildest dreams, and a sense of wonder and possibility that fills \nyou with excitement and anticipation.");
            DBranch();
        }//probe gateway then enter
        internal static void B2Branch()
        {
            Console.WriteLine("\n\"Let's use the ship's computer to analyze the transmission and see if it can decipher the code,\" you \nsay, hoping for a breakthrough. The communications officer works quickly, and after a few \nmoments, you have a translation.\r\n\r\n\"It says...\" the officer starts, but she's interrupted by the sound of alarms blaring. \"Captain, we've \ntriggered some kind of defensive mechanism. The structure is arming weapons!\" You feel a cold \nsweat break out on your forehead as you realize the danger you're in.");
            B2Branch_Choice();
        }//decipher automatically
        internal static void B2Branch_Choice()
        {
            Console.WriteLine("\nDo you:\r\n\r\n1) Fight back and attempt to disable the structure's weapons?\r\n2) Retreat immediately and try to outrun the structure's attack?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        B2Branch_Combat_GameOver();
                        break;
                    case 2:
                        B2Branch_Flee_GameOver();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        B2Branch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                B2Branch_Choice();
            }
        }//game over either way
        internal static void B2Branch_Combat_GameOver()
        {
            Console.WriteLine("\n\"We have no choice but to fight! Helm, evasive manoeuvres! Tactical, prepare all weapons and fire on the \nstructure!\" you shout, your heart pounding in your chest. The crew springs into action, and for a \nfew moments, it seems like you might have a chance.\r\n\r\nBut the structure's defences are too powerful, and your weapons barely scratch its surface. It \nretaliates with a devastating barrage of energy beams, and your shields start to buckle under the \nassault. \"We can't take much more of this, Captain!\" warns your first officer.\r\n\r\nIn a last ditch effort, you try to flee, but it's too late. The ship is \nrocked by a massive explosion, and everything goes dark. \r\n\r\nGame Over.");
            restartChapter();
        }//fight back game over
        internal static void B2Branch_Flee_GameOver()
        {
            Console.WriteLine("\n\"We have to get out of here,\" you shout, as you give the order to engage the engines and pull away \nfrom the structure. But it's too late. The structure's weapons lock onto your ship, and you're hit \nwith a barrage of powerful energy blasts.\r\n\r\nYour shields hold for a few moments, but then they start to buckle under the strain. You hear the \nscreams of your crewmates as you're thrown around the bridge, and you know that your fate is \nsealed. The last thing you see is the structure looming over you, victorious in its defence.\r\n\r\nGame Over.");
            restartChapter();
        }//run away game over
        internal static void CBranch()
        {
            Console.WriteLine("\nYou nod to the communications officer. \"Open a channel and send a greeting in every language we \nhave in our database. Let's hope they understand at least one of them.\" You wait anxiously for a \nresponse, but there's only silence. Just as you're about to give up, the structure emits a \nflash of light, activating your ships' brightness filters.\r\n\r\nAs your vision returns, you see that the structure has transformed, shifting and rearranging itself \ninto a new configuration. It now appears to be a gateway of some kind, leading to a dark, \nunknown expanse. \"Captain,\" says your science officer, \"I'm detecting a massive energy source on \nthe other side of the gateway. It's...beyond anything we've ever seen.\"");
            CBranch_Choice();
        } //respond in every known language
        internal static void CBranch_Choice()
        {
            Console.WriteLine("\nDo you:\r\n\r\n1) Proceed through the gateway to investigate?\r\n2) Retreat and gather more data before making a decision?\r\n3) Send a probe through the gateway to gather more data before proceeding?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        DBranch();
                        break;
                    case 2:
                        A3Branch();
                        break;
                    case 3:
                        B1_3Branch();
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        CBranch_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                CBranch_Choice();
            }
        }//D, game over, secret trigger then D
        internal static void DBranch() //through gateway
        {
            Console.WriteLine("\nYour heart racing with excitement, you make your decision. \"Helm, take us through the gateway. \nLet's see what lies on the other side.\" The crew braces themselves as you pass through the \npulsating energy field, and you feel a surge of energy pass through you.\r\n\r\nWhen you emerge on the other side, you find yourselves in an entirely new star system, one that's \nunlike anything you've ever seen before. The planets are larger, the stars brighter, and there's an \nenergy in the air that's palpable.\r\n\r\nAs you begin to explore this new frontier, you can't help but feel that you've uncovered something \ntruly special. But as you move deeper into the system, you begin to realize that you may have \nbitten off more than you can chew. There are forces at work here that are beyond your \nunderstanding, and the fate of the crew and the entire galaxy may be at stake.\r\n\r\nWhat challenges and mysteries will you face in this strange new star system? Only time will tell.");
            Console.WriteLine("end of current game, chapter 2 begins here");
            Console.ReadKey();
        }
        internal static void Template_Choice()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    default:
                        Game.InvalidInput("1-2");
                        Template_Choice();
                        break;
                }
            }
            else
            {
                Game.InvalidInput("1-2");
                Template_Choice();
            }
        }

    }
}