using FileCopy.Wif.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Wif.Top100Data
{
    public interface ITop100_2024DataService : ITop100DataService
    {
    }

    public class Top100_2024DataService : ITop100_2024DataService
    {
        public List<TrackData> ToList()
        {
            var returnValue = new List<TrackData>();
            var lines = Data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var value = line.Split("\t");
                _ = int.TryParse(value[0].ToString(), out int position);
                TrackData trackData = new()
                {
                    Position = position,
                    Artist = value[1].ToString(),
                    Title = value[2].ToString()
                };

                returnValue.Add(trackData);
            }

            return [.. returnValue.OrderByDescending(x => x.Position)];
        }

        private string Data => "1\tB B & Q Band\tDreamer\r\n2\tAdvance (ex nr. 1)\tTake me to the top\r\n3\tLuther Vandross  (ex nr 1 2023)\tNever too much\r\n4\tShannon (ex nr. 1)\tLet the music play\r\n5\tStone (ex nr.1)\tTime\r\n6\tCaptain Rapp\tBad times\r\n7\tD-Train (ex nr.1)\tYou're the one for me\r\n8\tKashif (ex nr. 1)\tI just gotta have you\r\n9\tHigh Fashion\tFeeling lucky lately\r\n10\tPlanet Patrol (ex nr.1)\tPlay at your own risk\r\n11\tSkyy\tShow me the way\r\n12\tC.O.D. (ex nr.1)\tIn the bottle\r\n13\tFatback Band\tIs this the future\r\n14\tDayton\tSound of music\r\n15\tDavid Joseph\tYou can't hide your love\r\n16\tTeri Jones\tDo it again\r\n17\tCurtis Hairston\tI want you all tonight\r\n18\tGLOBE & Whiz Kid\tPlay that beat\r\n19\tSOS Band\tJust be good to me\r\n20\tMan Parrish & Freeze Force Crew\tBoogie down Bronx\r\n21\tChange\tYou are my melody\r\n22\tSharon Redd\tBeat the street\r\n23\tBarkays\tShe talks to me with her body\r\n24\tUnique\tWhat I've got is what you need\r\n25\tBarbara Mason\tAnother man\r\n26\tStarpoint\tBring your sweet lovin' back\r\n27\tAlexander O'Neal\tCritisize\r\n28\tCool Runners\tPlay the game\r\n29\tMC Fosty C & Lovin' C\tRadio activity rapp\r\n30\tWorld Premiere\tShare the night\r\n31\tChocolate Milk\tWho's getting it now\r\n32\tSurface\tFalling in love\r\n33\tShannon\tGive me tonight\r\n34\tRene & Angela\tI'll be good\r\n35\tLuther Vandross\tI wanted your love\r\n36\tTony Cook & Party People\tOn the floor\r\n37\tDivine Sounds\tWhat people do for money\r\n38\tCherrelle\tWhen you look in my eyes\r\n39\tOliver Cheatham\tGet down on Saturday night\r\n40\tPeter Jacques Band\tGoing dancing down the street\r\n41\tSkyy\tHere's to you\r\n42\tXena\tOn the upside\r\n43\tUnlimited Touch\tSearching to find the one\r\n44\t52nd Street\tTell me\r\n45\tSOS Band\tThe finest\r\n46\tPink Rhythm\tCan't get enough of your love\r\n47\tMike & Brenda Sutton\tDon't let go of me\r\n48\tTramaine\tFall down\r\n49\tGeorge Benson\tInside love\r\n50\tNewcleus\tJam on it\r\n51\tRaw Silk\tJust in time\r\n52\tGayl Adams\tLove fever\r\n53\tMelba Moore (ex nr 1)\tLove's comin' at ya\r\n54\tWindjammer\tTossin and turnin'\r\n55\tChange\tHold tight\r\n56\tFat Larry's Band\tAct like you know\r\n57\tEarth, Wind & Fire\tStar\r\n58\tDouble Vision\tClock on the wall\r\n59\tMikki\tDance lover\r\n60\tMen at Play \tDr. Jam\r\n61\tLoose Ends\tHangin' on a string\r\n62\tGlenn Jones\tI am somebody\r\n63\tChaka Khan\tI Feel for you\r\n64\tRitchie Family\tI'll do my best for you baby\r\n65\tEvelyn King\tI'm in love\r\n66\tTony Scott\tLove let love\r\n67\tJeffrey Osbourne\tPlane love\r\n68\tToney Lee\tReach up\r\n69\tShalamar\tSecond time around\r\n70\tChemise\tShe can't love you\r\n71\tSystem, the\tThis is for you\r\n72\tClass Action\tWeekend\r\n73\t9.9\tAll of me\r\n74\tRose Royce\tBest love\r\n75\tVaughan Mason\tBounce rock skate roll\r\n76\tPatrice Rushen\tForget me nots\r\n77\tKeith Sweat\tI want her\r\n78\tSherrick\tJust call\r\n79\tMelba Moore\tKeepin' my lover satisfied\r\n80\tGary's Gang\tKnock me out\r\n81\tChange\tLovers holiday\r\n82\tBasis Black\tNothin' but a party\r\n83\tEugene Wilde\tPersonality\r\n84\tTimex Social Club\tRumors\r\n85\tTaste of Honey\tSayonara\r\n86\tJellybean\tSidewalk talk\r\n87\tTeena Marie\tSquare biz\r\n88\tTotal Contrast\tTakes a little time\r\n89\tBrandi Wells\tWatch out\r\n90\tDennis Edwards\tDon't look any further\r\n91\tLakeside\tFantastic voyage\r\n92\tNV\tIt's allright\r\n93\tBrothers Johnson\tStomp\r\n94\tGwen Guthrie\tAin't nothing going' on but the rent\r\n95\tHigh Fashion\tBreak up\r\n96\tPebbles\tGirlfriend\r\n97\tJocelyn Brown\tI wish you would\r\n98\tKleeer\tIntimate connection\r\n99\tImagination\tJust an illusion\r\n100\tGwen McCrae\tKeep the fire burning\r\n101\tJammFM\tTop100\r\n102\tJammFM\tTop100";
    }
}
