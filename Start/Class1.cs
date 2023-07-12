using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Data
    {
        public static string[] allChampionRoles = new string[]
        {
            "Top-Aatrox","Mid-Ahri","Mid-Akali","Support-Alistar","Jungle-Amumu","Mid-Anivia","Support-Annie","Bot-Aphelios","Bot-Ashe","Mid-AurelionSol","Mid-Azir","Support-Bard","Jungle-Bel'Veth","Support-Blitzcrank","Support-Brand","Support-Braum","Bot-Caitlyn","Top-Camille","Mid-Cassiopeia","Top-Cho'Gath","Mid-Corki","Top-Darius","Mid-Diana","Top-Dr.Mundo","Bot-Draven","Mid-Ekko","Jungle-Elise","Jungle-Evelynn","Bot-Ezreal","Support-Fiddlesticks","Top-Fiora","Mid-Fizz","Mid-Galio","Top-Gangplank","Top-Garen","Top-Gnar","Jungle-Gragas","Jungle-Graves","Top-Gwen","Jungle-Hecarim","Mid-Heimerdinger","Top-Illaoi","Top-Irelia","Jungle-Ivern","Support-Janna","Jungle-JarvanIV","Top-Jax","Top-Jayce","Bot-Jhin","Bot-Jinx","Mid-K'Sante","Bot-Kai'Sa","Bot-Kalista","Support-Karma","Mid-Karthus","Mid-Kassadin","Mid-Katarina","Top-Kayle","Jungle-Kayn","Top-Kennen","Jungle-Kha'Zix","Jungle-Kindred","Top-Kled","Bot-Kog'Maw","Mid-LeBlanc","Jungle-LeeSin","Support-Leona","Jungle-Lillia","Mid-Lissandra","Bot-Lucian","Support-Lulu","Support-Lux","Top-Malphite","Mid-Malzahar","Top-Maokai","Jungle-MasterYi","Top-Milio","Bot-MissFortune","Top-Mordekaiser","Support-Morgana","Mid-Naafiri","Support-Nami","Top-Nasus","Support-Nautilus","Mid-Neeko","Jungle-Nidalee","Bot-Nilah","Jungle-Nocturne","Jungle-Nunu&Willump","Top-Olaf","Mid-Orianna","Top-Ornn","Top-Pantheon","Top-Poppy","Support-Pyke","Mid-Qiyana","Top-Quinn","Support-Rakan","Jungle-Rammus","Jungle-Rek'Sai","Support-Rell","Support-RenataGlasc","Top-Renekton","Jungle-Rengar","Top-Riven","Top-Rumble","Mid-Ryze","Bot-Samira","Jungle-Sejuani","Support-Senna","Support-Seraphine","Mid-Sett","Jungle-Shaco","Top-Shen","Jungle-Shyvana","Top-Singed","Top-Sion","Bot-Sivir","Jungle-Skarner","Support-Sona","Support-Soraka","Support-Swain","Mid-Sylas","Mid-Syndra","Support-TahmKench","Mid-Taliyah","Mid-Talon","Support-Taric","Top-Teemo","Support-Thresh","Bot-Tristana","Jungle-Trundle","Top-Tryndamere","Mid-TwistedFate","Bot-Twitch","Jungle-Udyr","Top-Urgot","Bot-Varus","Bot-Vayne","Mid-Veigar","Mid-Vel'Koz","Mid-Vex","Jungle-Vi","Jungle-Viego","Mid-Viktor","Mid-Vladimir","Top-Volibear","Jungle-Warwick","Top-Wukong","Bot-Xayah","Mid-Xerath","Jungle-XinZhao","Mid-Yasuo","Mid-Yone","Top-Yorick","Support-Yuumi","Jungle-Zac","Mid-Zed","Bot-Zeri","Mid-Ziggs","Support-Zilean","Mid-Zoe","Support-Zyra", "Top-Akali", "Support-Amumu", "Support-Annie", "Support-Ashe", "Top-Cassiopeia", "Jungle-Diana", "Jungle-Dr.Mundo", "Jungle-Ekko", "Mid-Ezreal", "Jungle-Fiddlesticks", "Mid-Gangplank", "Top-Gragas", "Mid-Gragas", "Top-Heimerdinger", "Support-Heimerdinger", "Mid-Ireli", "Top-Ivern", "Mid-Ivern", "Support-Ivern", "Top-Janna", "Jungle-Jax", "Mid-Jayce", "Top-K'Sante", "Mid-Kai'Sa", "Top-Karma", "Bot-Karthus", "Jungle-Karthus", "Mid-Kayle", "Top-Kayn", "Mid-Kennen", "Mid-Neeko", "Jungle-Neeko", "Jungle-Pantheon", "Mid-Pantheon", "Support-Pantheon", "Jungle-Poppy", "Top-Rengar", "Mid-Renekton", "Mid-Rumble", "Top-Ryze", "Top-Sejuani", "Bot-Seraphine", "Mid-Seraphine", "Jungle-Talon", "Mid-Tristana", "Top-Trundle", "Mid-Varus", "Support-Vel'Koz", "Support-Veigar", "Top-Vladimir", "Jungle-Volibear", "Top-Warwick", "Jungle-Wukong", "Support-Xerath", "Top-Yasuo", "Top-Yone", "Top-Zac", "Bot-Ziggs", "Mid-Zilean"
        };  
        public static string[] allChampionRegions = new string[]
        {
            "Noxus-Aatrox", "Ionia-Ahri", "Ionia-Akali", "Runeterra-Alistar", "Shurima-Amumu",
            "Freljord-Anivia", "Noxus-Annie", "Targon-Aphelios", "Freljord-Ashe", "Targon-AurelionSol",
            "Shurima-Azir", "Targon-Bard", "Void-Bel'Veth", "Zaun-Blitzcrank", "Freljord-Brand",
            "Freljord-Braum", "Piltover-Caitlyn", "Piltover-Camille", "Noxus-Cassiopeia", "Void-Cho'Gath",
            "BandleCity-Corki", "Noxus-Darius", "Targon-Diana", "Zaun-Dr.Mundo", "Noxus-Draven",
            "Zaun-Ekko", "Noxus-Elise", "Runeterra-Evelynn", "Piltover-Ezreal", "Damacia-Fiddlesticks",
            "Demacia-Fiora", "Bilgewater-Fizz", "Demacia-Galio", "Bilgewater-Gangplank", "Demacia-Garen",
            "Runeterra-Gnar", "Freljord-Gragas", "Bilgewater-Graves", "ShadowIsles-Gwen", "ShadowIsles-Hecarim",
            "Piltover-Heimerdinger", "Bilgewater-Illaoi", "Ionia-Irelia", "Runeterra-Ivern", "Shurima-Janna",
            "Demacia-JarvanIV", "Shurima-Jax", "Piltover-Jayce", "Piltover-Jhin", "Zaun-Jinx",
            "Shurima-K'Sante", "Shurima-Kai'Sa", "ShadowIsles-Kalista", "Ionia-Karma", "ShadowIsles-Karthus",
            "ShadowIsles-Kassadin", "Noxus-Katarina", "Demacia-Kayle", "Ionia-Kayn", "Ionia-Kennen",
            "Void-Kha'Zix", "Runeterra-Kindred", "Noxus-Kled", "Void-Kog'Maw", "Noxus-LeBlanc",
            "Ionia-LeeSin", "Targon-Leona", "Ionia-Lillia", "Freljord-Lissandra", "Demacia-Lucian",
            "BandleCity-Lulu", "Demacia-Lux", "Ionia-Malphite", "Void-Malzahar", "ShadowIsles-Maokai",
            "Ionia-MasterYi", "Ixtal-Milio", "Bilgewater-MissFortune", "Shurima-Mordekaiser", "Demacia-Morgana",
            "Shurima-Naafiri", "Water-Nami", "Shurima-Nasus", "Bilgewater-Nautilus", "Ionia-Neeko",
            "Ionia-Nidalee", "Runeterra-Nilah", "Runeterra-Nocturne", "Freljord-Nunu&Willump", "Freljord-Olaf",
            "Piltover-Orianna", "Freljord-Ornn", "Targon-Pantheon", "Demacia-Poppy", "Bilgewater-Pyke",
            "Ixtal-Qiyana", "Demacia-Quinn", "Ionia-Rakan", "Shurima-Rammus", "Void-Rek'Sai",
            "Noxus-Rell", "Zaun-RenataGlasc", "Shurima-Renekton", "Ionia-Rengar", "Noxus-Riven",
            "BandleCity-Rumble", "Runeterra-Ryze", "Noxus-Samira", "Freljord-Sejuani", "ShadowIsles-Senna",
            "Piltover-Seraphine", "Ionia-Sett", "Runeterra-Shaco", "Ionia-Shen", "Damacia-Shyvana",
            "Zaun-Singed", "Noxus-Sion", "Shurima-Sivir", "Shurima-Skarner", "Demacia-Sona",
            "Targon-Soraka", "Noxus-Swain", "Demacia-Sylas", "Ionia-Syndra", "Bilgewater-TahmKench",
            "Shurima-Taliyah", "Noxus-Talon", "Targon-Taric", "BandleCity-Teemo", "ShadowIsles-Thresh",
            "BandleCity-Tristana", "Freljord-Trundle", "Freljord-Tryndamere", "Bilgewater-TwistedFate", "Zaun-Twitch",
            "Frejlord-Udyr", "Noxus-Urgot", "Ionia-Varus", "Demacia-Vayne", "BandleCity-Veigar",
            "Void-Vel'Koz", "ShadowIsles-Vex", "Zaun-Vi", "ShadowIsles-Viego", "Zaun-Viktor",
            "Noxus-Vladimir", "Freljord-Volibear", "Zaun-Warwick", "Ionia-Wukong", "Ionia-Xayah",
            "Shurima-Xerath", "Demacia-XinZhao", "Ionia-Yasuo", "Ionia-Yone", "ShadowIsles-Yorick",
            "BandleCity-Yuumi", "Zaun-Zac", "Ionia-Zed", "Zaun-Zeri", "Piltover-Ziggs", "Zaun-Zilean",
            "Targon-Zoe", "Shuriima-Zyra"

        };  
        public static string[] allChampionReleaseDates = new string[]
        {
            "2023-Naafiri 19/07", "2023-Milio 22/03", "2022-K'Sante 03/11", "2022-Nilah 13/07", "2022-Bel'Veth 09/06", "2022-Renata Glasc 17/02", "2022-Zeri 20/01", "2021-Vex 23/09", "2021-Akshan 22/07", "2021-Gwen 15/04", "2021-Viego 21/01", "2020-Rell 10/12", "2020-Seraphine 29/10", "2020-Samira 21/09", "2020-Yone 06/08", "2020-Lillia 22/07", "2020-Sett 14/01", "2019-Aphelios 11/12", "2019-Senna 10/11", "2019-Qiyana 28/06", "2019-Yuumi 14/05", "2019-Sylas 25/01", "2018-Neeko 05/12", "2018-Pyke 31/05", "2018-Kai'Sa 07/03", "2017-Zoe 21/11", "2017-Ornn 23/08", "2017-Kayn 12/07", "2017-Rakan 19/04", "2017-Xayah 19/04", "2016-Camille 07/12", "2016-Ivern 05/10", "2016-Kled 10/08", "2016-Taliyah 18/05", "2016-Aurelion Sol 24/03", "2016-Jhin 01/02", "2015-Illaoi 24/11", "2015-Kindred 14/10", "2015-Tahm Kench 09/07", "2015-Ekko 29/05", "2015-Bard 12/03", "2014-Rek'Sai 11/12", "2014-Kalista 20/11", "2014-Azir 16/09", "2014-Gnar 14/08", "2014-Braum 12/05", "2014-Vel'Koz 27/02", "2013-Yasuo 13/12", "2013-Jinx 10/10", "2013-Lucian 22/08", "2013-Aatrox 13/06", "2013-Lissandra 30/04", "2013-Zac 29/03", "2013-Quinn 01/03", "2013-Thresh 23/01", "2012-Vi 19/12", "2012-Nami 07/12", "2012-Zed 13/11", "2012-Elise 26/10", "2012-Kha'Zix 27/09", "2012-Syndra 13/09", "2012-Rengar 21/08", "2012-Diana 07/08", "2012-Zyra 24/07", "2012-Jayce 07/07", "2012-Draven 06/06", "2012-Darius 23/05", "2012-Varus 08/05", "2012-Hecarim 18/04", "2012-Lulu 20/03", "2012-Fiora 29/02", "2012-Nautilus 14/02", "2012-Ziggs 01/02", "2011-Sejuani 17/01", "2011-Viktor 29/12", "2011-Ahri 14/12", "2011-Volibear 29/11", "2011-Fizz 15/11", "2011-Graves 19/10", "2011-Xerath 05/10", "2011-Riven 14/09", "2011-Talon 24/08", "2011-Skarner 09/08", "2011-Wukong 26/07", "2011-Leona 13/07", "2011-Yorick 22/06", "2011-Orianna 01/06", "2011-Vayne 10/05", "2011-Rumble 26/04", "2011-Brand 12/04", "2011-Lee Sin 01/04", "2011-Nocturne 15/03", "2011-Jarvan IV 01/03", "2011-Maokai 16/02", "2011-Karma 01/02", "2011-Renekton 18/01", "2011-Shyvana 11/01", "2011-Caitlyn 04/01", "2010-Cassiopeia 14/12", "2010-Trundle 01/12", "2010-Irelia 16/11", "2010-LeBlanc 02/11", "2010-Lux 19/10", "2010-Swain 05/10", "2010-Sona 21/09", "2010-Miss Fortune 08/09", "2010-Urgot 24/08", "2010-Galio 10/08", "2010-Vladimir 27/07", "2010-Xin Zhao 13/07", "2010-Kog'Maw 24/06", "2010-Olaf 09/06", "2010-Malzahar 01/06", "2010-Akali 11/05", "2010-Garen 27/04", "2010-Kennen 08/04", "2010-Shen 24/03", "2010-Ezreal 16/03", "2010-Mordekaiser 24/02", "2010-Gragas 02/02", "2010-Pantheon 02/02", "2010-Poppy 13/01", "2009-Nidalee 17/12", "2009-Udyr 02/12", "2009-Heimerdinger 10/10", "2009-Shaco 10/10", "2009-Nasus 01/10", "2009-Corki 19/09", "2009-Katarina 19/09", "2009-Blitzcrank 02/09", "2009-Dr. Mundo 02/09", "2009-Janna 02/09", "2009-Malphite 02/09", "2009-Gangplank 19/08", "2009-Taric 19/08", "2009-Kassadin 07/08", "2009-Veigar 27/07", "2009-Anivia 10/07", "2009-Rammus 10/07", "2009-Amumu 26/06", "2009-Cho'Gath 26/06", "2009-Karthus 12/06", "2009-Evelynn 01/05", "2009-Tryndamere 01/05", "2009-Twitch 01/05", "2009-Singed 18/04", "2009-Zilean 18/04", "2009-Alistar 21/02", "2009-Annie 21/02", "2009-Ashe 21/02", "2009-Fiddlesticks 21/02", "2009-Jax 21/02", "2009-Kayle 21/02", "2009-Master Yi 21/02", "2009-Morgana 21/02", "2009-Nunu & Willump 21/02", "2009-Ryze 21/02", "2009-Sion 21/02", "2009-Sivir 21/02", "2009-Soraka 21/02", "2009-Teemo 21/02", "2009-Tristana 21/02", "2009-Twisted Fate 21/02", "2009-Warwick 21/02", "2009-Wukong 21/02", "2009-Xayah 21/02", "2009-Xerath 21/02", "2009-Xin Zhao 21/02", "2009-Yasuo 21/02", "2009-Yorick 21/02", "2009-Yuumi 21/02", "2009-Zac 21/02", "2009-Zed 21/02", "2009-Ziggs 21/02", "2009-Zilean 21/02", "2009-Zoe 21/02", "2009-Zyra 21/02"
        }; 
        public static string[] allChampionClasses = new string[]
        {
            "Fighter-Aatrox", "Mage-Ahri", "Assassin-Akali", "Tank-Alistar", "Tank-Amumu", "Mage-Anivia", "Mage-Annie",
             "Marksman-Aphelios", "Marksman-Ashe", "Mage-Aurelion sol", "Mage-Azir", "Support-Bard", "Fighter-Bel'Veth",
             "Support-Blitzcrank", "Mage-Brand", "Support-Braum", "Marksman-Caitlyn", "Fighter-Camille", "Mage-Cassiopeia",
             "Tank-Cho'Gath", "Marksman-Corki", "Fighter-Daius", "Assassin-Diana", "Fighter-Dr.Mundo", "Marksman-Draven",
             "Assassin-Ekko", "Assassin-Elise", "Assassin-Evelynn", "Marksman-Ezreal", "Mage-Fiddlesticks", "Fighter-Fiora",
             "Assassin-Fizz", "Tank-Galio", "Fighter-Gangplank", "Fighter-Garen", "Fighter-Gnar", "Tank-Gragas",
             "Marksman-Graves", "Fighter-Gwen", "Fighter-Hecarim", "Mage-Heimerdinger", "Fighter-Illaoi", "Fighter-Irelia",
             "Support-Ivern", "Support-Janna", "Tank-Jarvan IV", "Fighter-Jax", "Fighter-Jayce", "Marksman-Jhin",
             "Marksman-Jinx", "Tank-K'Sante", "Marksman-Kai'Sa", "Marksman-Kalista", "Mage-Karma", "Mage-Karthus",
             "Assassin-Kassadin", "Assassin-Katarina", "Fighter-Kayle", "Assassin-Kayn", "Mage-Kennen", "Assassin-Kha'Zix",
             "Marksman-Kindred", "Fighter-Kled", "Marksman-Kog'Maw", "Assassin-LeBlanc", "Fighter-Lee Sin", "Tank-Leona",
             "Mage-Lillia", "Mage-Lissandra", "Marksman-Lucian", "Support-Lulu", "Mage-Lux", "Tank-Malphite",
             "Mage-Malzahar", "Tank-Maokai", "Fighter-Master YI", "Support-Milio", "Marksman-Miss Fortune",
             "Fighter-Mordekaiser", "Mage-Morgana", "Assassin-Naafiri", "Support-Nami", "Fighter-Nasus", "Tank-Nautilus",
             "Mage-Neeko", "Assassin-Nidalee", "Marksman-Nilah", "Assassin-Nocturne", "Tank-Nunu & Willump", "Fighter-Olaf",
             "Mage-Orianna", "Tank-Ornn", "Fighter-Pantheon", "Tank-Poppy", "Assassin-Pyke", "Assassin-Qiyana",
             "Marksman-Quinn", "Support-Rakan", "Tank-Rammus", "Fighter-Rek'Sai", "Support-Rell", "Support-Renata Glasc",
             "Fighter-Renekton", "Assassin-Rengar", "Fighter-Riven", "Mage-Rumble", "Mage-Ryze", "Marksman-Samira",
             "Tank-Sejuani", "Marksman-Senna", "Mage-Seraphine", "Fighter-Sett", "Assassin-Shaco", "Tank-Shen",
             "Fighter-Shyvana", "Tank-Singed", "Tank-Sion", "Marksman-Sivir", "Fighter-Skarner", "Support-Sona",
             "Support-Soraka", "Mage-Swain", "Mage-Sylas", "Mage-Syndra", "Support-Tahm Kench", "Mage-Taliyah",
             "Assassin-Talon", "Support-Taric", "Mage-Teemo", "Support-Thresh", "Marksman-Tristana", "Fighter-Trundle",
             "Fighter-Tryndamere", "Mage-Twisted Fate", "Marksman-Twitch", "Fighter-Udyr", "Fighter-Urgot", "Marksman-Varus",
             "Marksman-Vayne", "Mage-Veigar", "Mage-Vel'Koz", "Mage-Vex", "Fighter-Vi", "Assassin-Viego", "Mage-Viktor",
             "Mage-Vladimir", "Fighter-Volibear", "Fighter-Warwick", "Fighter-Wukong", "Marksman-Xayah", "Mage-Xerath",
             "Fighter-Xin Zhao", "Fighter-Yasuo", "Assassin-Yone", "Fighter-Yorick", "Support-Yuumi", "Tank-Zac",
             "Assassin-Zed", "Marksman-Zeri", "Mage-Ziggs", "Support-Zilean", "Mage-Zoe", "Mage-Zyra"

        };
        public static string[] allChampionsAlphabetically = new string[]
        {
            "A-Aatrox", "A-Ahri", "A-Akali", "A-Alistar", "A-Amumu",
             "A-Anivia", "A-Annie", "A-Aphelios", "A-Ashe", "A-Aurelion sol",
             "A-Azir", "B-Bard", "B-Bel'Veth", "B-Blitzcrank", "B-Brand",
             "B-Braum", "C-Caitlyn", "C-Camille", "C-Cassiopeia", "C-Cho'Gath",
             "C-Corki", "D-Daius", "D-Diana", "D-Dr.Mundo", "D-Draven",
             "E-Ekko", "E-Elise", "E-Evelynn", "E-Ezreal", "F-Fiddlesticks",
             "F-Fiora", "F-Fizz", "G-Galio", "G-Gangplank", "G-Garen",
             "G-Gnar", "G-Gragas", "G-Graves", "G-Gwen", "H-Hecarim",
             "H-Heimerdinger", "I-Illaoi", "I-Irelia", "I-Ivern", "J-Janna",
             "J-Jarvan IV", "J-Jax", "J-Jayce", "J-Jhin", "J-Jinx",
             "K-K'Sante", "K-Kai'Sa", "K-Kalista", "K-Karma", "K-Karthus",
             "K-Kassadin", "K-Katarina", "K-Kayle", "K-Kayn", "K-Kennen",
             "K-Kha'Zix", "K-Kindred", "K-Kled", "K-Kog'Maw", "L-LeBlanc",
             "L-Lee Sin", "L-Leona", "L-Lillia", "L-Lissandra", "L-Lucian",
             "L-Lulu", "L-Lux", "M-Malphite", "M-Malzahar", "M-Maokai",
             "M-Master YI", "M-Milio", "M-Miss Fortune", "M-Mordekaiser", "M-Morgana",
             "N-Naafiri", "N-Nami", "N-Nasus", "N-Nautilus", "N-Neeko",
             "N-Nidalee", "N-Nilah", "N-Nocturne", "N-Nunu & Willump", "O-Olaf",
             "O-Orianna", "O-Ornn", "P-Pantheon", "P-Poppy", "P-Pyke",
             "Q-Qiyana", "Q-Quinn", "R-Rakan", "R-Rammus", "R-Rek'Sai",
             "R-Rell", "R-Renata Glasc", "R-Renekton", "R-Rengar", "R-Riven",
             "R-Rumble", "R-Ryze", "S-Samira", "S-Sejuani", "S-Senna",
             "S-Seraphine", "S-Sett", "S-Shaco", "S-Shen", "S-Shyvana",
             "S-Singed", "S-Sion", "S-Sivir", "S-Skarner", "S-Sona",
             "S-Soraka", "S-Swain", "S-Sylas", "S-Syndra", "T-Tahm Kench",
             "T-Taliyah", "T-Talon", "T-Taric", "T-Teemo", "T-Thresh",
             "T-Tristana", "T-Trundle", "T-Tryndamere", "T-Twisted Fate", "T-Twitch",
             "U-Udyr", "U-Urgot", "V-Varus", "V-Vayne", "V-Veigar",
             "V-Vel'Koz", "V-Vex", "V-Vi", "V-Viego", "V-Viktor",
             "V-Vladimir", "V-Volibear", "W-Warwick", "W-Wukong", "X-Xayah",
             "X-Xerath", "X-Xin Zhao", "Y-Yasuo", "Y-Yone", "Y-Yorick",
             "Y-Yuumi", "Z-Zac", "Z-Zed", "Z-Zeri", "Z-Ziggs",
             "Z-Zilean", "Z-Zoe", "Z-Zyra"

        };
        public static string[] allChampions = new string[]
        {
            "Aatrox", "Ahri", "Akali" ,"Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe", "Aurelion sol","Azir", "Bard", "Bel'Veth", "Blitzcrank", "Brand", "Braum", "Caitlyn", "Camille", "Cassiopeia", "Cho'Gath", "Corki", "Daius", "Diana","Dr.Mundo", "Draven", "Ekko", "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen", "Gnar","Gragas", "Graves", "Gwen", "Hecarim", "Heimerdinger", "Illaoi", "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx","K'Sante", "Kai'Sa", "Kalista", "Karma", "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled","Kog'Maw", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu", "Lux", "Malphite", "Malzahar", "Maokai", "Master YI","Milio", "Miss Fortune", "Mordekaiser", "Morgana", "Naafiri", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nilah", "Nocturne", "Nunu & Willump","Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn", "Rakan", "Rammus", "Rek'Sai", "Rell", "Renata Glasc", "Renekton","Rengar", "Riven", "Rumble", "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvana", "Singed", "Sion","Sivir", "Skarner", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench", "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana","Trundle", "Trndamere", "Twisted Fate", "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz", "Vex", "Vi", "Viego", "Viktor","Vladimir", "Volibear", "Warwick", "Wukong", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi", "Zac", "Zed", "Zeri", "Ziggs", "Zilean", "Zoe", "Zyra"

        };
        public static string[] allRoles = new string[]
        {
            "Top","Jungle","Mid","Bot","Support"
        };
        public static string[] allRegions = new string[]
        {
          "Noxus", "Ionia", "Runeterra", "Freljord", "Shurima", "Bilgewater", "Zaun", "Piltover", "Ixtal", "Targon", "BandleCity", "Void","ShadowIsles"
        };
        public static string[] allClasses = new string[]
        {
           "Fighter", "Mage", "Assassin", "Tank", "Marksman", "Support"
        };
        public static string[] releaseDates = new string[]
        {
           "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010","2009"
        };
        public static string[] alphabet = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M","N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };
    }
}
