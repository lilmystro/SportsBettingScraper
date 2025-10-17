using SportBettingScraper.Models;

namespace SportBettingScraper.Core;

public class LivescoreLeagues
{
    public static List<League> GetLeagues(List<TeamCornerStats> merged)
    {
        return
        [
            new League("England Premier League",
                       "https://www.livescore.com/en/football/england/premier-league/standings/",
                       "https://www.livescore.com/en/football/england/premier-league/fixtures/",
                       GetTeamsList("England Premier League", GetTeamAliases("England Premier League"), merged)
                       ),
            new League("Germany Bundesliga",
                       "https://www.livescore.com/en/football/germany/bundesliga/standings/",
                       "https://www.livescore.com/en/football/germany/bundesliga/fixtures/",
                       GetTeamsList("Germany Bundesliga", GetTeamAliases("Germany Bundesliga"), merged)
                       ),
            new League("Spain La Liga",
                       "https://www.livescore.com/en/football/spain/laliga/standings/",
                       "https://www.livescore.com/en/football/spain/laliga/fixtures/",
                       GetTeamsList("Spain La Liga", GetTeamAliases("Spain La Liga"), merged)
                       ),
            new League("Italy Serie A",
                       "https://www.livescore.com/en/football/italy/serie-a/standings/",
                       "https://www.livescore.com/en/football/italy/serie-a/fixtures/",
                       GetTeamsList("Italy Serie A", GetTeamAliases("Italy Serie A"), merged)
                       ),
            new League("France Ligue 1",
                       "https://www.livescore.com/en/football/france/ligue-1/standings/",
                       "https://www.livescore.com/en/football/france/ligue-1/fixtures/",
                       GetTeamsList("France Ligue 1", GetTeamAliases("France Ligue 1"), merged)
                       ),
            // --- Argentina ---
            //new League(
            //    "Argentina Liga Profesional",
            //    "https://www.livescore.com/en/football/argentina/primera-division/",
            //    "https://www.livescore.com/en/football/argentina/primera-division/fixtures/",
            //    GetTeamsList("Argentina Liga Profesional", GetTeamAliases("Argentina Liga Profesional"), merged)
            //),
            //new League(
            //    "Argentina Nacional B",
            //    "https://www.livescore.com/en/football/argentina/nacional-b/",
            //    "https://www.livescore.com/en/football/argentina/nacional-b/fixtures/",
            //    GetTeamsList("Argentina Nacional B", GetTeamAliases("Argentina Nacional B"), merged)
            //),

            // --- Armenia ---
            //new League(
            //    "Armenia Premier League",
            //    "https://www.livescore.com/en/football/armenia/premier-league/",
            //    "https://www.livescore.com/en/football/armenia/premier-league/fixtures/",
            //    GetTeamsList("Armenia Premier League", GetTeamAliases("Armenia Premier League"), merged)
            //),

            // --- Australia ---
            //new League(
            //    "Australia A-League",
            //    "https://www.livescore.com/en/football/australia/a-league/standings/",
            //    "https://www.livescore.com/en/football/australia/a-league/fixtures/",
            //    GetTeamsList("Australia A-League", GetTeamAliases("Australia A-League"), merged)
            //),

            // --- Austria ---
            new League(
                "Austria Bundesliga",
                "https://www.livescore.com/en/football/austria/bundesliga/standings/",
                "https://www.livescore.com/en/football/austria/bundesliga/fixtures/",
                GetTeamsList("Austria Bundesliga", GetTeamAliases("Austria Bundesliga"), merged)
            ),
            //new League(
            //    "Austria 2. Liga",
            //    "https://www.livescore.com/en/football/austria/2-liga/standings/",
            //    "https://www.livescore.com/en/football/austria/2-liga/fixtures/",
            //    GetTeamsList("Austria 2. Liga", GetTeamAliases("Austria 2. Liga"), merged)
            //),

            // --- Azerbaijan ---
            //new League(
            //    "Azerbaijan Premier League",
            //    "https://www.livescore.com/en/football/azerbaijan/premier-league/standings/",
            //    "https://www.livescore.com/en/football/azerbaijan/premier-league/fixtures/",
            //    GetTeamsList("Azerbaijan Premier League", GetTeamAliases("Azerbaijan Premier League"), merged)
            //),

            // --- Bahrain ---
            //new League(
            //    "Bahrain Premier League",
            //    "https://www.livescore.com/en/football/bahrain/premier-league/standings/",
            //    "https://www.livescore.com/en/football/bahrain/premier-league/fixtures/",
            //    GetTeamsList("Bahrain Premier League", GetTeamAliases("Bahrain Premier League"), merged)
            //),

            // --- Belarus ---
            //new League(
            //    "Belarus Vysshaya Liga",
            //    "https://www.livescore.com/en/football/belarus/premier-league/standings/",
            //    "https://www.livescore.com/en/football/belarus/premier-league/fixtures/",
            //    GetTeamsList("Belarus Vysshaya Liga", GetTeamAliases("Belarus Vysshaya Liga"), merged)
            //),

            // --- Belgium ---
            new League(
                "Belgium First Division A",
                "https://www.livescore.com/en/football/belgium/belgian-pro-league/standings/",
                "https://www.livescore.com/en/football/belgium/belgian-pro-league/fixtures/",
                GetTeamsList("Belgium First Division A", GetTeamAliases("Belgium First Division A"), merged)
            ),
            //new League(
            //    "Belgium 1B Pro League",
            //    "https://www.livescore.com/en/football/belgium/first-division-b/standings/", // formerly Proximus League
            //    "https://www.livescore.com/en/football/belgium/first-division-b/fixtures/",
            //    GetTeamsList("Belgium 1B Pro League", GetTeamAliases("Belgium 1B Pro League"), merged)
            //),

            // --- Bolivia ---
            //new League(
            //    "Bolivia Division Profesional",
            //    "https://www.livescore.com/en/football/bolivia/primera-division/standings/",
            //    "https://www.livescore.com/en/football/bolivia/primera-division/fixtures/",
            //    GetTeamsList("Bolivia Division Profesional", GetTeamAliases("Bolivia Division Profesional"), merged)
            //),

            // --- Bosnia and Herzegovina ---
            //new League(
            //    "Bosnia and Herzegovina Premier League",
            //    "https://www.livescore.com/en/football/bosnia-and-herzegovina/premier-league/standings/",
            //    "https://www.livescore.com/en/football/bosnia-and-herzegovina/premier-league/fixtures/",
            //    GetTeamsList("Bosnia and Herzegovina Premier League", GetTeamAliases("Bosnia and Herzegovina Premier League"), merged)
            //),

            // --- Brazil ---
            //new League(
            //    "Brazil Serie A",
            //    "https://www.livescore.com/en/football/brazil/serie-a/standings/",
            //    "https://www.livescore.com/en/football/brazil/serie-a/fixtures/",
            //    GetTeamsList("Brazil Serie A", GetTeamAliases("Brazil Serie A"), merged)
            //),
            //new League(
            //    "Brazil Serie B",
            //    "https://www.livescore.com/en/football/brazil/serie-b/standings/",
            //    "https://www.livescore.com/en/football/brazil/serie-b/fixtures/",
            //    GetTeamsList("Brazil Serie B", GetTeamAliases("Brazil Serie B"), merged)
            //),

            // --- Bulgaria ---
            //new League(
            //    "Bulgaria Parva liga",
            //    "https://www.livescore.com/en/football/bulgaria/first-league/standings/",
            //    "https://www.livescore.com/en/football/bulgaria/first-league/fixtures/",
            //    GetTeamsList("Bulgaria Parva liga", GetTeamAliases("Bulgaria Parva liga"), merged)
            //),

            // --- Chile ---
            //new League(
            //    "Chile Primera Division",
            //    "https://www.livescore.com/en/football/chile/primera-division/standings/",
            //    "https://www.livescore.com/en/football/chile/primera-division/fixtures/",
            //    GetTeamsList("Chile Primera Division", GetTeamAliases("Chile Primera Division"), merged)
            //),
            //new League(
            //    "Chile Primera B",
            //    "https://www.livescore.com/en/football/chile/primera-b/standings/",
            //    "https://www.livescore.com/en/football/chile/primera-b/fixtures/",
            //    GetTeamsList("Chile Primera B", GetTeamAliases("Chile Primera B"), merged)
            //),

            // --- China ---
            //new League(
            //    "China Super League",
            //    "https://www.livescore.com/en/football/china/super-league/standings/",
            //    "https://www.livescore.com/en/football/china/super-league/fixtures/",
            //    GetTeamsList("China Super League", GetTeamAliases("China Super League"), merged)
            //),

            // --- Colombia ---
            new League(
                "Colombia Primera A",
                "https://www.livescore.com/en/football/colombia/primera-a-clausura/standings/",
                "https://www.livescore.com/en/football/colombia/primera-a-clausura/fixtures/",
                GetTeamsList("Colombia Primera A", GetTeamAliases("Colombia Primera A"), merged)
            ),
            //new League(
            //    "Colombia Primera B",
            //    "https://www.livescore.com/en/football/colombia/primera-b-clausura/standings/",
            //    "https://www.livescore.com/en/football/colombia/primera-b-clausura/fixtures/",
            //    GetTeamsList("Colombia Primera B", GetTeamAliases("Colombia Primera B"), merged)
            //),

            // --- Costa Rica ---
            //new League(
            //    "Costa Rica Primera Division",
            //    "https://www.livescore.com/en/football/costa-rica/primera-division/",
            //    "https://www.livescore.com/en/football/costa-rica/primera-division/fixtures/",
            //    GetTeamsList("Costa Rica Primera Division", GetTeamAliases("Costa Rica Primera Division"), merged)
            //),

            // --- Croatia ---
            //new League(
            //    "Croatia 1.HNL",
            //    "https://www.livescore.com/en/football/croatia/1-hnl/",
            //    "https://www.livescore.com/en/football/croatia/1-hnl/fixtures/",
            //    GetTeamsList("Croatia 1.HNL", GetTeamAliases("Croatia 1.HNL"), merged)
            //),
            //new League(
            //    "Croatia 2. HNL",
            //    "https://www.livescore.com/en/football/croatia/2nd-league/standings/",
            //    "https://www.livescore.com/en/football/croatia/2nd-league/fixtures/",
            //    GetTeamsList("Croatia 2. HNL", GetTeamAliases("Croatia 2. HNL"), merged)
            //),

            // --- Cyprus ---
            //new League(
            //    "Cyprus First Division",
            //    "https://www.livescore.com/en/football/cyprus/1-division/standings/",
            //    "https://www.livescore.com/en/football/cyprus/1-division/fixtures/",
            //    GetTeamsList("Cyprus First Division", GetTeamAliases("Cyprus First Division"), merged)
            //),

            // --- Czech Republic ---
            //new League(
            //    "Czech Republic 1. Liga",
            //    "https://www.livescore.com/en/football/czech-republic/1st-league/standings/",
            //    "https://www.livescore.com/en/football/czech-republic/1st-league/fixtures/",
            //    GetTeamsList("Czech Republic 1. Liga", GetTeamAliases("Czech Republic 1. Liga"), merged)
            //),
            //new League(
            //    "Czech Republic Division 2",
            //    "https://www.livescore.com/en/football/czech-republic/2nd-league/standings/",
            //    "https://www.livescore.com/en/football/czech-republic/2nd-league/fixtures/",
            //    GetTeamsList("Czech Republic Division 2", GetTeamAliases("Czech Republic Division 2"), merged)
            //),

            // --- Denmark ---
            //new League(
            //    "Denmark Superligaen",
            //    "https://www.livescore.com/en/football/denmark/superliga/standings/",
            //    "https://www.livescore.com/en/football/denmark/superliga/fixtures/",
            //    GetTeamsList("Denmark Superligaen", GetTeamAliases("Denmark Superligaen"), merged)
            //),
            //new League(
            //    "Denmark Division 1",
            //    "https://www.livescore.com/en/football/denmark/division-1/",
            //    "https://www.livescore.com/en/football/denmark/division-1/fixtures/",
            //    GetTeamsList("Denmark Division 1", GetTeamAliases("Denmark Division 1"), merged)
            //),
            //new League(
            //    "Estonia Meistriliiga",
            //    "https://www.livescore.com/en/football/estonia/meistriliiga/standings/",
            //    "https://www.livescore.com/en/football/estonia/meistriliiga/fixtures/",
            //    GetTeamsList("Estonia Meistriliiga", GetTeamAliases("Estonia Meistriliiga"), merged)
            //),

            new League(
                "Finland Veikkausliiga",
                "https://www.livescore.com/en/football/finland/veikkausliiga/standings/",
                "https://www.livescore.com/en/football/finland/veikkausliiga/fixtures/",
                GetTeamsList("Finland Veikkausliiga", GetTeamAliases("Finland Veikkausliiga"), merged)
            ),

            //new League(
            //    "Finland Ykkosliiga",
            //    "https://www.livescore.com/en/football/finland/ykkosliiga/standings/",
            //    "https://www.livescore.com/en/football/finland/ykkosliiga/fixtures/",
            //    GetTeamsList("Finland Ykkosliiga", GetTeamAliases("Finland Ykkosliiga"), merged)
            //),

            new League(
                "Germany Bundes II",
                "https://www.livescore.com/en/football/germany/2-bundesliga/standings/",
                "https://www.livescore.com/en/football/germany/2-bundesliga/fixtures/",
                GetTeamsList("Germany Bundes II", GetTeamAliases("Germany Bundes II"), merged)
            ),

            //new League(
            //    "Greece Super League",
            //    "https://www.livescore.com/en/football/greece/super-league/standings/",
            //    "https://www.livescore.com/en/football/greece/super-league/fixtures/",
            //    GetTeamsList("Greece Super League", GetTeamAliases("Greece Super League"), merged)
            //),
            //new League(
            //    "Holland Eerste Divisie",
            //    "https://www.livescore.com/en/football/netherlands/eerste-divisie/standings/",
            //    "https://www.livescore.com/en/football/netherlands/eerste-divisie/fixtures/",
            //    GetTeamsList("Holland Eerste Divisie", GetTeamAliases("Holland Eerste Divisie"), merged)
            //),
            new League(
                "Holland Eredivisie",
                "https://www.livescore.com/en/football/netherlands/eredivisie/standings/",
                "https://www.livescore.com/en/football/netherlands/eredivisie/fixtures/",
                GetTeamsList("Holland Eredivisie", GetTeamAliases("Holland Eredivisie"), merged)
            ),
            //new League(
            //    "Hungary NB II",
            //    "https://www.livescore.com/en/football/hungary/nb-ii/",
            //    "https://www.livescore.com/en/football/hungary/nb-ii/fixtures/",
            //    GetTeamsList("Hungary NB II", GetTeamAliases("Hungary NB II"), merged)
            //),
            //new League(
            //    "Iceland Pepsideild",
            //    "https://www.livescore.com/en/football/iceland/pepsideild/",
            //    "https://www.livescore.com/en/football/iceland/pepsideild/fixtures/",
            //    GetTeamsList("Iceland Pepsideild", GetTeamAliases("Iceland Pepsideild"), merged)
            //),
            //new League(
            //    "India ISL",
            //    "https://www.livescore.com/en/football/india/isl/",
            //    "https://www.livescore.com/en/football/india/isl/fixtures/",
            //    GetTeamsList("India ISL", GetTeamAliases("India ISL"), merged)
            //),
            //new League(
            //    "Ireland Division 1",
            //    "https://www.livescore.com/en/football/ireland/first-division/standings/",  // possible mapping
            //    "https://www.livescore.com/en/football/ireland/first-division/fixtures/",
            //    GetTeamsList("Ireland Division 1", GetTeamAliases("Ireland Division 1"), merged)
            //),
            //new League(
            //    "Ireland Premier Division",
            //    "https://www.livescore.com/en/football/ireland/league-of-ireland-premier-division/standings/",
            //    "https://www.livescore.com/en/football/ireland/league-of-ireland-premier-division/fixtures/",
            //    GetTeamsList("Ireland Premier Division", GetTeamAliases("Ireland Premier Division"), merged)
            //),
            //new League(
            //    "Israel Leumit League",
            //    "https://www.livescore.com/en/football/israel/liga-leumit/standings/",
            //    "https://www.livescore.com/en/football/israel/liga-leumit/fixtures/",
            //    GetTeamsList("Israel Leumit League", GetTeamAliases("Israel Leumit League"), merged)
            //),
            //new League(
            //    "Israel Ligat ha Al",
            //    "https://www.livescore.com/en/football/israel/premier-league/standings/",
            //    "https://www.livescore.com/en/football/israel/premier-league/fixtures/",
            //    GetTeamsList("Israel Ligat ha Al", GetTeamAliases("Israel Ligat ha Al"), merged)
            //),
            new League(
                "Italy Serie B",
                "https://www.livescore.com/en/football/italy/serie-b/standings/",
                "https://www.livescore.com/en/football/italy/serie-b/fixtures/",
                GetTeamsList("Italy Serie B", GetTeamAliases("Italy Serie B"), merged)
            ),
            new League(
                "Japan J-League",
                "https://www.livescore.com/en/football/japan/j-league/standings/",
                "https://www.livescore.com/en/football/japan/j-league/fixtures/",
                GetTeamsList("Japan J-League", GetTeamAliases("Japan J-League"), merged)
            ),
            //new League(
            //    "Japan J2-League",
            //    "https://www.livescore.com/en/football/japan/j2-league/standings/",
            //    "https://www.livescore.com/en/football/japan/j2-league/fixtures/",
            //    GetTeamsList("Japan J2-League", GetTeamAliases("Japan J2-League"), merged)
            //),
            //new League(
            //    "Jordan Premier League",
            //    "https://www.livescore.com/en/football/jordan/pro-league/standings/",
            //    "https://www.livescore.com/en/football/jordan/pro-league/fixtures/",
            //    GetTeamsList("Jordan Premier League", GetTeamAliases("Jordan Premier League"), merged)
            //),
            //new League(
            //    "Kazakhstan Premier League",
            //    "https://www.livescore.com/en/football/kazakhstan/premier-league/standings/",
            //    "https://www.livescore.com/en/football/kazakhstan/premier-league/fixtures/",
            //    GetTeamsList("Kazakhstan Premier League", GetTeamAliases("Kazakhstan Premier League"), merged)
            //),
            //new League(
            //    "Kuwait Premier League",
            //    "https://www.livescore.com/en/football/kuwait/premier-league/standings/",
            //    "https://www.livescore.com/en/football/kuwait/premier-league/fixtures/",
            //    GetTeamsList("Kuwait Premier League", GetTeamAliases("Kuwait Premier League"), merged)
            //),
            //new League(
            //    "Lithuania A Lyga",
            //    "https://www.livescore.com/en/football/lithuania/a-lyga/standings/",
            //    "https://www.livescore.com/en/football/lithuania/a-lyga/fixtures/",
            //    GetTeamsList("Lithuania A Lyga", GetTeamAliases("Lithuania A Lyga"), merged)
            //),
            //new League(
            //    "Malaysia Super League",
            //    "https://www.livescore.com/en/football/malaysia/super-league/standings/",
            //    "https://www.livescore.com/en/football/malaysia/super-league/fixtures/",
            //    GetTeamsList("Malaysia Super League", GetTeamAliases("Malaysia Super League"), merged)
            //),
            //new League(
            //    "Malta Premier League",
            //    "https://www.livescore.com/en/football/malta/premier-league/standings/",
            //    "https://www.livescore.com/en/football/malta/premier-league/fixtures/",
            //    GetTeamsList("Malta Premier League", GetTeamAliases("Malta Premier League"), merged)
            //),
            new League(
                "Mexico Apertura",
                "https://www.livescore.com/en/football/mexico/liga-mx/standings/",
                "https://www.livescore.com/en/football/mexico/liga-mx/fixtures/",
                GetTeamsList("Mexico Apertura", GetTeamAliases("Mexico Apertura"), merged)
            ),
            //new League(
            //    "Montenegro Prva Crnogorska Liga",
            //    "https://www.livescore.com/en/football/montenegro/1-cfl/standings/",
            //    "https://www.livescore.com/en/football/montenegro/1-cfl/fixtures/",
            //    GetTeamsList("Montenegro Prva Crnogorska Liga", GetTeamAliases("Montenegro Prva Crnogorska Liga"), merged)
            //),
            //new League(
            //    "Morocco Botola Pro",
            //    "https://www.livescore.com/en/football/morocco/botola-pro/standings/",
            //    "https://www.livescore.com/en/football/morocco/botola-pro/fixtures/",
            //    GetTeamsList("Morocco Botola Pro", GetTeamAliases("Morocco Botola Pro"), merged)
            //),
            //new League(
            //    "Northern Ireland NIFL Premiership",
            //    "https://www.livescore.com/en/football/northern-ireland/premiership/standings/",
            //    "https://www.livescore.com/en/football/northern-ireland/premiership/fixtures/",
            //    GetTeamsList("Northern Ireland NIFL Premiership", GetTeamAliases("Northern Ireland NIFL Premiership"), merged)
            //),

            //new League(
            //    "Norway Eliteserien",
            //    "https://www.livescore.com/en/football/norway/eliteserien/standings/",
            //    "https://www.livescore.com/en/football/norway/eliteserien/fixtures/",
            //    GetTeamsList("Norway Eliteserien", GetTeamAliases("Norway Eliteserien"), merged)
            //),
            //new League(
            //    "Norway Division 1",
            //    "https://www.livescore.com/en/football/norway/1-division/standings/",
            //    "https://www.livescore.com/en/football/norway/1-division/fixtures/",
            //    GetTeamsList("Norway Division 1", GetTeamAliases("Norway Division 1"), merged)
            //),

            //new League(
            //    "Paraguay Primera Division",
            //    "https://www.livescore.com/en/football/paraguay/division-profesional-clausura/standings/",
            //    "https://www.livescore.com/en/football/paraguay/division-profesional-clausura/fixtures/",
            //    GetTeamsList("Paraguay Primera Division", GetTeamAliases("Paraguay Primera Division"), merged)
            //),

            //new League(
            //    "Peru Liga 1",
            //    "https://www.livescore.com/en/football/peru/liga-1/standings/",
            //    "https://www.livescore.com/en/football/peru/liga-1/fixtures/",
            //    GetTeamsList("Peru Liga 1", GetTeamAliases("Peru Liga 1"), merged)
            //),

            new League(
                "Poland Ekstraklasa",
                "https://www.livescore.com/en/football/poland/ekstraklasa/standings/",
                "https://www.livescore.com/en/football/poland/ekstraklasa/fixtures/",
                GetTeamsList("Poland Ekstraklasa", GetTeamAliases("Poland Ekstraklasa"), merged)
            ),
            //new League(
            //    "Poland I Liga",
            //    "https://www.livescore.com/en/football/poland/i-liga/standings/",
            //    "https://www.livescore.com/en/football/poland/i-liga/fixtures/",
            //    GetTeamsList("Poland I Liga", GetTeamAliases("Poland I Liga"), merged)
            //),

            //new League(
            //    "Portugal Primeira Liga",
            //    "https://www.livescore.com/en/football/portugal/primeira-liga/standings/",
            //    "https://www.livescore.com/en/football/portugal/primeira-liga/fixtures/",
            //    GetTeamsList("Portugal Primeira Liga", GetTeamAliases("Portugal Primeira Liga"), merged)
            //),
            //new League(
            //    "Portugal Segunda Liga",
            //    "https://www.livescore.com/en/football/portugal/segunda-liga/standings/",
            //    "https://www.livescore.com/en/football/portugal/segunda-liga/fixtures/",
            //    GetTeamsList("Portugal Segunda Liga", GetTeamAliases("Portugal Segunda Liga"), merged)
            //),

            //new League(
            //    "Qatar QSL",
            //    "https://www.livescore.com/en/football/qatar/qatar-stars-league/standings/",
            //    "https://www.livescore.com/en/football/qatar/qatar-stars-league/fixtures/",
            //    GetTeamsList("Qatar QSL", GetTeamAliases("Qatar QSL"), merged)
            //),

            new League(
                "Romania Liga I",
                "https://www.livescore.com/en/football/romania/liga-1/standings/",
                "https://www.livescore.com/en/football/romania/liga-1/fixtures/",
                GetTeamsList("Romania Liga I", GetTeamAliases("Romania Liga I"), merged)
            ),
            //new League(
            //    "Romania Liga II",
            //    "https://www.livescore.com/en/football/romania/liga-ii/standings/",
            //    "https://www.livescore.com/en/football/romania/liga-ii/fixtures/",
            //    GetTeamsList("Romania Liga II", GetTeamAliases("Romania Liga II"), merged)
            //),
            
            //new League(
            //    "Russia FNL",
            //    "https://www.livescore.com/en/football/russia/fnl/",
            //    "https://www.livescore.com/en/football/russia/fnl/fixtures/",
            //    GetTeamsList("Russia FNL", GetTeamAliases("Russia FNL"), merged)
            //),
            //new League(
            //    "Russia Premier League",
            //    "https://www.livescore.com/en/football/russia/premier-league/",
            //    "https://www.livescore.com/en/football/russia/premier-league/fixtures/",
            //    GetTeamsList("Russia Premier League", GetTeamAliases("Russia Premier League"), merged)
            //),
            
            new League(
                "Saudi Arabia Saudi Professional",
                "https://www.livescore.com/en/football/saudi-arabia/saudi-professional-league/standings/",
                "https://www.livescore.com/en/football/saudi-arabia/saudi-professional-league/fixtures/",
                GetTeamsList("Saudi Arabia Saudi Professional", GetTeamAliases("Saudi Arabia Saudi Professional"), merged)
            ),

            //new League(
            //    "Scotland Premiership",
            //    "https://www.livescore.com/en/football/scotland/premiership/standings/",
            //    "https://www.livescore.com/en/football/scotland/premiership/fixtures/",
            //    GetTeamsList("Scotland Premiership", GetTeamAliases("Scotland Premiership"), merged)
            //),
            //new League(
            //    "Scotland Championship",
            //    "https://www.livescore.com/en/football/scotland/championship/standings/",
            //    "https://www.livescore.com/en/football/scotland/championship/fixtures/",
            //    GetTeamsList("Scotland Championship", GetTeamAliases("Scotland Championship"), merged)
            //),
            //new League(
            //    "Scotland League One",
            //    "https://www.livescore.com/en/football/scotland/league-one/",
            //    "https://www.livescore.com/en/football/scotland/league-one/fixtures/",
            //    GetTeamsList("Scotland League One", GetTeamAliases("Scotland League One"), merged)
            //),
            //new League(
            //    "Scotland League Two",
            //    "https://www.livescore.com/en/football/scotland/league-two/",
            //    "https://www.livescore.com/en/football/scotland/league-two/fixtures/",
            //    GetTeamsList("Scotland League Two", GetTeamAliases("Scotland League Two"), merged)
            //),
            
            //new League(
            //    "Serbia Super Liga",
            //    "https://www.livescore.com/en/football/serbia/super-liga/standings/",
            //    "https://www.livescore.com/en/football/serbia/super-liga/fixtures/",
            //    GetTeamsList("Serbia Super Liga", GetTeamAliases("Serbia Super Liga"), merged)
            //),

            //new League(
            //    "Slovakia Fortuna liga",
            //    "https://www.livescore.com/en/football/slovakia/fortuna-liga/standings/",
            //    "https://www.livescore.com/en/football/slovakia/fortuna-liga/fixtures/",
            //    GetTeamsList("Slovakia Fortuna liga", GetTeamAliases("Slovakia Fortuna liga"), merged)
            //),
            //new League(
            //    "Slovenia Prva liga",
            //    "https://www.livescore.com/en/football/slovenia/prva-liga/standings/",
            //    "https://www.livescore.com/en/football/slovenia/prva-liga/fixtures/",
            //    GetTeamsList("Slovenia Prva liga", GetTeamAliases("Slovenia Prva liga"), merged)
            //),

            //new League(
            //    "South Africa Premier League",
            //    "https://www.livescore.com/en/football/south-africa/premier-league/standings/",
            //    "https://www.livescore.com/en/football/south-africa/premier-league/fixtures/",
            //    GetTeamsList("South Africa Premier League", GetTeamAliases("South Africa Premier League"), merged)
            //),

            //new League(
            //    "South Korea K League 1",
            //    "https://www.livescore.com/en/football/republic-of-korea/k-league-1/standings/",
            //    "https://www.livescore.com/en/football/republic-of-korea/k-league-1/fixtures/",
            //    GetTeamsList("South Korea K League 1", GetTeamAliases("South Korea K League 1"), merged)
            //),
            //new League(
            //    "South Korea K League 2",
            //    "https://www.livescore.com/en/football/republic-of-korea/k-league-2/standings/",
            //    "https://www.livescore.com/en/football/republic-of-korea/k-league-2/fixtures/",
            //    GetTeamsList("South Korea K League 2", GetTeamAliases("South Korea K League 2"), merged)
            //),

            new League(
                "Spain Segunda",
                "https://www.livescore.com/en/football/spain/laliga-2/standings/",
                "https://www.livescore.com/en/football/spain/laliga-2/fixtures/",
                GetTeamsList("Spain Segunda", GetTeamAliases("Spain Segunda"), merged)
            ),

            //new League(
            //    "Sweden Allsvenskan",
            //    "https://www.livescore.com/en/football/sweden/allsvenskan/standings/",
            //    "https://www.livescore.com/en/football/sweden/allsvenskan/fixtures/",
            //    GetTeamsList("Sweden Allsvenskan", GetTeamAliases("Sweden Allsvenskan"), merged)
            //),
            //new League(
            //    "Sweden Superettan",
            //    "https://www.livescore.com/en/football/sweden/superettan/standings/",
            //    "https://www.livescore.com/en/football/sweden/superettan/fixtures/",
            //    GetTeamsList("Sweden Superettan", GetTeamAliases("Sweden Superettan"), merged)
            //),

            //new League(
            //    "Switzerland Super League",
            //    "https://www.livescore.com/en/football/switzerland/super-league/standings/",
            //    "https://www.livescore.com/en/football/switzerland/super-league/fixtures/",
            //    GetTeamsList("Switzerland Super League", GetTeamAliases("Switzerland Super League"), merged)
            //),
            //new League(
            //    "Switzerland Challenge League",
            //    "https://www.livescore.com/en/football/switzerland/challenge-league/standings/",
            //    "https://www.livescore.com/en/football/switzerland/challenge-league/fixtures/",
            //    GetTeamsList("Switzerland Challenge League", GetTeamAliases("Switzerland Challenge League"), merged)
            //),

            //new League(
            //    "Thailand Thai League 1",
            //    "https://www.livescore.com/en/football/thailand/thai-league/standings/",
            //    "https://www.livescore.com/en/football/thailand/thai-league/fixtures/",
            //    GetTeamsList("Thailand Thai League 1", GetTeamAliases("Thailand Thai League 1"), merged)
            //),

            new League(
                "Turkey Super Lig",
                "https://www.livescore.com/en/football/turkiye/super-lig/standings/",
                "https://www.livescore.com/en/football/turkeye/super-lig/fixtures/",
                GetTeamsList("Turkey Super Lig", GetTeamAliases("Turkey Super Lig"), merged)
            ),
            //new League(
            //    "Turkey 1. Lig",
            //    "https://www.livescore.com/en/football/turkiye/1st-lig/standings/",
            //    "https://www.livescore.com/en/football/turkiye/1st-lig/fixtures/",
            //    GetTeamsList("Turkey 1. Lig", GetTeamAliases("Turkey 1. Lig"), merged)
            //),

            //new League(
            //    "Ukraine Premier League",
            //    "https://www.livescore.com/en/football/ukraine/premier-league/standings/",
            //    "https://www.livescore.com/en/football/ukraine/premier-league/fixtures/",
            //    GetTeamsList("Ukraine Premier League", GetTeamAliases("Ukraine Premier League"), merged)
            //),

            //new League(
            //    "United Arab Emirates UAE League",
            //    "https://www.livescore.com/en/football/united-arab-emirates/uae-league/standings/",
            //    "https://www.livescore.com/en/football/united-arab-emirates/uae-league/fixtures/",
            //    GetTeamsList("United Arab Emirates UAE League", GetTeamAliases("United Arab Emirates UAE League"), merged)
            //),

            //new League(
            //    "Uruguay Primera Division",
            //    "https://www.livescore.com/en/football/uruguay/primera-division-clausura/standings/",
            //    "https://www.livescore.com/en/football/uruguay/primera-division-clausura/fixtures/",
            //    GetTeamsList("Uruguay Primera Division", GetTeamAliases("Uruguay Primera Division"), merged)
            //),
            
            /*new League(
                "USA MLS",
                "https://www.livescore.com/en/football/usa/mls/",
                "https://www.livescore.com/en/football/usa/mls/fixtures/",
                GetTeamsList("USA MLS", GetTeamAliases("USA MLS"), merged)
            ),*/
            
            /*new League(
                "USA USL Championship",
                "https://www.livescore.com/en/football/usa/usl-championship/",
                "https://www.livescore.com/en/football/usa/usl-championship/fixtures/",
                GetTeamsList("USA USL Championship", GetTeamAliases("USA USL Championship"), merged)
            ),*/
            
            //new League(
            //    "Venezuela Primera Division",
            //    "https://www.livescore.com/en/football/venezuela/primera-division-clausura/standings/",
            //    "https://www.livescore.com/en/football/venezuela/primera-division-clausura/fixtures/",
            //    GetTeamsList("Venezuela Primera Division", GetTeamAliases("Venezuela Primera Division"), merged)
            //),

            //new League(
            //    "Vietnam V.League 1",
            //    "https://www.livescore.com/en/football/vietnam/v-league/standings/",
            //    "https://www.livescore.com/en/football/vietnam/v-league/fixtures/",
            //    GetTeamsList("Vietnam V.League 1", GetTeamAliases("Vietnam V.League 1"), merged)
            //),

            //new League(
            //    "Wales Cymru Premier",
            //    "https://www.livescore.com/en/football/wales/cymru-premier/standings/",
            //    "https://www.livescore.com/en/football/wales/cymru-premier/fixtures/",
            //    GetTeamsList("Wales Cymru Premier", GetTeamAliases("Wales Cymru Premier"), merged)
            //),
        ];
    }

    public static List<string> GetTeamsList(string leagueName, Dictionary<string, string> teamAliases, List<TeamCornerStats> merged)
    {
        // Original team list from CSV
        var csvTeams = merged
            .Where(x => x.League.Contains(leagueName, StringComparison.OrdinalIgnoreCase))
            .Select(x => x.Team.Trim())
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        // Convert CSV names to LiveScore equivalents using aliases
        var finalTeams = csvTeams
            .Select(t => teamAliases.TryGetValue(t, out var alias) ? alias : t)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        return finalTeams;
    }

    public static Dictionary<string, string> GetTeamAliases(string leagueName)
    {
        if (leagueName.Contains("England Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Arsenal", "Arsenal" },
                { "Aston Villa", "Aston Villa" },
                { "Bournemouth", "AFC Bournemouth" },
                { "Brentford", "Brentford" },
                { "Brighton", "Brighton" },
                { "Burnley", "Burnley" },
                { "Chelsea", "Chelsea" },
                { "Crystal Palace", "Crystal Palace" },
                { "Everton", "Everton" },
                { "Fulham", "Fulham" },
                { "Leeds", "Leeds United" },
                { "Liverpool", "Liverpool" },
                { "Man City", "Manchester City" },
                { "Man Utd", "Manchester United" },
                { "Newcastle", "Newcastle United" },
                { "Nottm Forest", "Nottingham Forest" },
                { "Sunderland", "Sunderland" },
                { "Tottenham", "Tottenham Hotspur" },
                { "West Ham", "West Ham United" },
                { "Wolverhampton", "Wolves" }
            };
        }
        else if (leagueName.Contains("Germany Bundesliga", StringComparison.OrdinalIgnoreCase))
        {
            // aliases for Bundesliga teams
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Augsburg", "Augsburg" },
                { "Bayer Leverkusen", "Bayer Leverkusen" },
                { "Bayern Munich", "Bayern Munich" },
                { "Borussia Dortmund", "Borussia Dortmund" },
                { "Borussia M'gladbach", "Borussia M'gladbach" },
                { "Cologne", "FC Cologne" },
                { "Eintracht Frankfurt", "Eintracht Frankfurt" },
                { "Hamburg", "Hamburger SV" },
                { "Heidenheim", "FC Heidenheim" },
                { "Mainz", "Mainz 05" },
                { "RB Leipzig", "RB Leipzig" },
                { "SC Freiburg", "Freiburg" },
                { "St Pauli", "St.Pauli" },
                { "TSG Hoffenheim", "Hoffenheim" },
                { "Union Berlin", "Union Berlin" },
                { "VfB Stuttgart", "VfB Stuttgart" },
                { "Werder Bremen", "Werder Bremen" },
                { "Wolfsburg", "Wolfsburg" }
            };
        }
        else if (leagueName.Contains("Spain La Liga", StringComparison.OrdinalIgnoreCase))
        {
            // aliases for La Liga teams
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Athletic Bilbao", "Athletic Club" },
                { "Atletico Madrid", "Atletico Madrid" },
                { "Barcelona", "Barcelona" },
                { "CD Alaves", "Deportivo Alaves" },
                { "Celta Vigo", "Celta Vigo" },
                { "Elche", "Elche" },
                { "Espanyol", "Espanyol" },
                { "Getafe", "Getafe" },
                { "Girona", "Girona" },
                { "Levante", "Levante" },
                { "Mallorca", "Mallorca" },
                { "Osasuna", "Osasuna" },
                { "Oviedo", "Real Oviedo" },
                { "Rayo Vallecano", "Rayo Vallecano" },
                { "Real Betis", "Real Betis" },
                { "Real Madrid", "Real Madrid" },
                { "Real Sociedad", "Real Sociedad" },
                { "Sevilla", "Sevilla" },
                { "Valencia", "Valencia" },
                { "Villarreal", "Villarreal" }
            };

        }
        else if (leagueName.Contains("Italy Serie A", StringComparison.OrdinalIgnoreCase))
        {
            // aliases for Serie A teams
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "AC Milan", "AC Milan" },
                { "Atalanta", "Atalanta" },
                { "Bologna", "Bologna" },
                { "Cagliari", "Cagliari" },
                { "Como 1907", "Como" },
                { "Cremonese", "Cremonese" },
                { "Fiorentina", "Fiorentina" },
                { "Genoa", "Genoa" },
                { "Inter", "Inter Milan" },
                { "Juventus", "Juventus" },
                { "Lazio", "Lazio" },
                { "Lecce", "Lecce" },
                { "Napoli", "Napoli" },
                { "Parma", "Parma" },
                { "Pisa", "Pisa" },
                { "AS Roma", "Roma" },
                { "Sassuolo", "Sassuolo" },
                { "Torino", "Torino" },
                { "Udinese", "Udinese" },
                { "Hellas Verona", "Verona" }
            };
        }
        else if (leagueName.Contains("France Ligue 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Angers", "Angers" },
                { "Auxerre", "Auxerre" },
                { "Brest", "Brest" },
                { "Le Havre", "Le Havre" },
                { "Lens", "Lens" },
                { "Lille", "Lille" },
                { "Lorient", "Lorient" },
                { "Lyon", "Lyon" },
                { "Marseille", "Marseille" },
                { "Metz", "Metz" },
                { "Monaco", "AS Monaco" },
                { "Nantes", "Nantes" },
                { "Nice", "Nice" },
                { "Paris FC", "Paris FC" },
                { "PSG", "Paris Saint-Germain"},
                { "Rennes", "Rennes" },
                { "Strasbourg", "Strasbourg" },
                { "Toulouse", "Toulouse" }
            };
        }
        else if (leagueName.Contains("Argentina Liga Profesional", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Argentinos Jrs", "Argentinos Juniors" },
                { "Atlético Tucumán", "Atletico Tucuman" },
                { "Banfield", "Banfield" },
                { "Barracas Central", "Barracas Central" },
                { "Belgrano", "Belgrano" },
                { "Boca Juniors", "Boca Juniors" },
                { "CA Aldosivi", "Aldosivi" },
                { "CA Independiente", "Independiente" },
                { "CA Platense", "Club Atletico Platense" },
                { "CA Talleres", "Talleres" },
                { "CA Tigre", "Tigre" },
                { "Central Cordoba SdE", "Central Cordoba de Santiago" },
                { "Defensa y Justicia", "Defensa y Justicia" },
                { "Deportivo Riestra", "Deportivo Riestra" },
                { "Estudiantes LP", "Estudiantes de la Plata" },
                { "Gimnasia LP", "Gimnasia LP" },
                { "Godoy Cruz", "Godoy Cruz" },
                { "Huracan", "CA Huracan" },
                { "Independiente Rivadavia De Mendoza", "Independiente Rivadavia" },
                { "Instituto AC Cordoba", "Instituto Cordoba" },
                { "Lanus", "Lanus" },
                { "Newell's", "Newell's Old Boys" },
                { "Racing Club", "Racing Club" },
                { "River Plate", "River Plate" },
                { "Rosario Central", "Rosario Central" },
                { "San Lorenzo", "San Lorenzo de Almagro" },
                { "San Martin de San Juan", "San Martin San Juan" },
                { "Sarmiento", "Sarmiento" },
                { "Union Santa Fe", "Union" },
                { "Velez Sarsfield", "Velez Sarsfield" }
            };
        }
        else if (leagueName.Contains("Argentina Nacional B", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Agropecuario", "Agropecuario" },
                { "All Boys", "All Boys" },
                { "Almagro", "Almagro" },
                { "Almirante Brown", "Almirante Brown" },
                { "Arsenal de Sarandi", "Arsenal de Sarandí" },
                { "CA Alvarado", "Alvarado" },
                { "CA Atlanta", "Atlanta" },
                { "CA Estudiantes Caseros", "Estudiantes Caseros" },
                { "CA Guemes", "Güemes" },
                { "CA San Telmo", "San Telmo" },
                { "Central Norte", "Central Norte" },
                { "Chacarita Juniors", "Chacarita Juniors" },
                { "Chaco For Ever", "Chaco For Ever" },
                { "Club Atletico Mitre", "Mitre" },
                { "Club Atletico Temperley", "Temperley" },
                { "Colegiales", "Colegiales" },
                { "Colon", "Colón" },
                { "Defensores de Belgrano", "Defensores de Belgrano" },
                { "Defensores Unidos", "Defensores Unidos" },
                { "Deportivo Madryn", "Deportivo Madryn" },
                { "Deportivo Maipu", "Deportivo Maipú" },
                { "Deportivo Moron", "Morón" },
                { "Estudiantes Rio Cuarto", "Estudiantes Río Cuarto" },
                { "Ferro Carril Oeste", "Ferro Carril Oeste" },
                { "Gimnasia Jujuy", "Gimnasia Jujuy" },
                { "Gimnasia Mendoza", "Gimnasia Mendoza" },
                { "Gimnasia y Tiro", "Gimnasia y Tiro" },
                { "Los Andes", "Los Andes" },
                { "Nueva Chicago", "Nueva Chicago" },
                { "Patronato Parana", "Patronato" },
                { "Quilmes", "Quilmes" },
                { "Racing Córdoba", "Racing Córdoba" },
                { "San Martin de Tucuman", "San Martín de Tucumán" },
                { "San Miguel", "San Miguel" },
                { "Talleres Remedios", "Talleres (RE)" },
                { "Tristan Suarez", "Tristán Suárez" }
            };
        }
        else if (leagueName.Contains("Armenia Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Alashkert", "FC Alashkert" },
                { "Ararat", "Ararat Yerevan" },
                { "Ararat-Armenia", "Ararat Armenia" },
                { "Noah", "FC Noah" },
                { "Urartu", "Urartu FC" }
            };
        }
        else if (leagueName.Contains("Australia A-League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Auckland", "Auckland FC" },
                { "Brisbane Roar", "Brisbane Roar FC" },
                { "Melbourne City", "Melbourne City FC" },
                { "Western Sydney Wanderers", "Western Sydney Wanderers FC" }
            };
        }
        else if (leagueName.Contains("Austria 2. Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Austria Klagenfurt", "SK Austria Klagenfurt" },
                { "FC Trenkwalder Admira", "FC Admira Wacker Modling" },
                { "First Vienna", "First Vienna FC" },
                { "FK Austria Vienna II", "Young Violets" },
                { "Rapid Vienna II", "SK Rapid Wien II" },
                { "SKU Amstetten", "Amstetten" },
                { "St Polten", "SKN St. Poelten" },
                { "Sturm Graz (Am)", "Sturm Graz II" },
                { "SV Kapfenberg", "Kapfenberger SV" },
                { "WSPG Wels", "FC Hertha Wels" },
                { "Bregenz", "SW Bregenz" }
            };
        }
        else if (leagueName.Contains("Austria Bundesliga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "FC Blau Weiss Linz", "BW Linz" },
                { "FK Austria Vienna", "Austria Wien" },
                { "Hartberg", "TSV Hartberg" },
                { "LASK Linz", "LASK" },
                { "Rapid Vienna", "Rapid Wien" },
                { "SK Sturm Graz", "Sturm Graz" },
                { "WSG Swarovski Tirol", "WSG Tirol" }
            };
        }
        else if (leagueName.Contains("Azerbaijan Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Araz", "Araz PFK" },
                { "Kapaz", "FC Kapaz" },
                { "Qarabag", "Qarabag FK" },
                { "Sabah", "Sabah FK" },
                { "Qabala", "Gabala FK" },
                { "Neftçi", "FK Neftchi" },
                { "Turan", "Turan Tovuz" },
                { "Karvan", "Karvan FK" },
                { "Sumqayit", "Sumqayit" },
                { "Mil-Mugan", "Imisli FK" },
                { "Kesla FK", "Shamakhi FK" }
            };
        }
        else if (leagueName.Contains("Bahrain Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "A'Ali", "A’Aali" },
                { "Al Ahli", "Al Ahli" },
                { "Al Khalidiyah", "Al Khalidiyah" },
                { "Al Riffa", "Al Riffa" },
                { "Al Shabbab Manama", "Al Shabab Manama" },
                { "Al-Hidd", "Al-Hidd" },
                { "Al-Najma", "Al-Najma" },
                { "Bahrain SC", "Bahrain SC" },
                { "Budaiya", "Budaiya" },
                { "Malkiya", "Malkiya" },
                { "Muharraq", "Muharraq" },
                { "Sitra", "Sitra" }
            };
        }
        else if (leagueName.Contains("Belarus Vysshaya Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Arsenal", "Arsenal Dzerzhinsk" },
                { "BATE", "BATE Borisov" },
                { "Minsk", "FC Minsk" },
                { "Naftan", "Naftan Novopolotsk" },
                { "Slavia", "Slavia Mozyr" },
                { "Slutsk", "FK Slutsk" },
                { "Smorgon", "FC Smorgon" },
                { "Vitebsk", "FK Vitebsk" },
                { "Molodechno-DYuSSh 4", "FK Molodechno" },
                { "Torpedo BelAZ", "Torpedo Zhodino" },
                { "MKK-Dnepr", "Maxline Vitebsk" } // recently rebranded
            };
        }
        else if (leagueName.Contains("Belgium First Division A", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Club Brugge", "Club Brugge" },
                { "Anderlecht", "RSC Anderlecht" },
                { "Standard Liege", "Standard Liège" },
                { "Genk", "KRC Genk" },
                { "Gent", "KAA Gent" },
                { "Charleroi", "Royal Charleroi" },
                { "Cercle Brugge", "Cercle Brugge" },
                { "Antwerp", "Royal Antwerp" },
                { "St. Truiden", "Sint-Truiden" },
                { "Oostende", "KV Oostende" },
                { "Mechelen", "KV Mechelen" },
                { "Westerlo", "KVC Westerlo" },
                { "Zulte Waregem", "Zulte-Waregem" },
                { "OH Leuven", "Oud-Heverlee Leuven" },
                { "Clyde-Leuven", "Oud-Heverlee Leuven" }, // sometimes variant
                { "Union SG", "Union Saint-Gilloise" }
            };
        }
        else if (leagueName.Contains("Belgium 1B Pro League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "RWDM", "RWDM 47" },
                { "Mouscron", "Royal Excel Mouscron" },
                { "Virton", "R.E. Virton" },
                { "Lierse", "Lierse Kempenzonen" },
                { "Beerschot", "K Beerschot VA" },
                { "Eupen", "KAS Eupen" }
            };
        }
        else if (leagueName.Contains("Bolivia Division Profesional", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Bolívar", "Club Bolívar" },
                { "The Strongest", "The Strongest" },
                { "Wilstermann", "C.D. Jorge Wilstermann" },
                { "Oriente", "Oriente Petrolero" },
                { "Blooming", "Club Blooming" },
                { "Always Ready", "Club Always Ready" }
            };
        }
        else if (leagueName.Contains("Bosnia and Herzegovina Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Sarajevo", "FK Sarajevo" },
                { "Velez", "FK Velez Mostar" },
                { "Zrinjski", "Zrinjski Mostar" }
            };
        }
        else if (leagueName.Contains("Brazil Serie A", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Atletico Mineiro", "Atletico MG" },
                { "EC Bahia", "Bahia" },
                { "EC Juventude", "Juventude" },
                { "Botafogo RJ", "Botafogo FR" },
                { "Bragantino", "RB Bragantino" },
                { "Fortaleza FC", "Fortaleza" },
                { "Santos", "Santos FC" },
                { "Vasco Da Gama RJ", "Vasco da Gama" }
            };
        }
        else if (leagueName.Contains("Brazil Serie B", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Athletico Paranaense", "Athletico Paranaense" }, // from Serie A club, but if it's listed here, you can verify contextually
                { "Atletico Goianiense", "Atletico GO" },
                { "Avai", "Avai FC" },
                { "Chapecoense", "Chapecoense AF" },
                { "Ferroviária", "Ferroviaria" },
                { "Operario PR", "Operario Ferroviario" }
            };
        }
        else if (leagueName.Contains("Bulgaria Parva liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "CSKA Sofia", "PFC CSKA Sofia" },
                { "Levski Sofia", "PFC Levski Sofia" },
                { "Ludogorets", "PFC Ludogorets Razgrad" }
            };
        }
        else if (leagueName.Contains("Chile Primera Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Universidad Chile", "Universidad de Chile" },
                { "Universidad Católica", "Universidad Catolica" },
                { "Unión Española", "Union Espanola" },
                { "Unión La Calera", "Union La Calera" },
                { "Everton", "Everton CD" },
                { "Ñublense", "Atletico Nublense" },
                { "Club Deportes Limache", "Limache" } // full CSV name vs short LiveScore
            };
        }
        else if (leagueName.Contains("Chile Primera B", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Univ. Concepción", "Universidad de Concepcion" },
                { "Copiapó", "Deportes Copiapo" },
                { "Concepcion", "Deportes Concepcion" },
                { "Recoleta", "Deportes Recoleta" },
                { "Unión San Felipe", "Union San Felipe" },
                { "Deportes Santa Cruz", "Deportes Santa Cruz" }
            };
        }
        else if (leagueName.Contains("China Super League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Dalian Zhixing", "Dalian Yingbo FC" },
                { "Hangzhou Lucheng", "Zhejiang Professional" },
                { "Qingdao Jonoon", "Qingdao Hainiu" },
                { "Qingdao Youth Island", "Qingdao West Coast" },
                { "Shenzhen Xinpengcheng", "Shenzhen Peng City" },
                { "Tianjin Tigers", "Tianjin Jinmen Tiger" }
            };
        }
        else if (leagueName.Contains("Colombia Primera A", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Atletico Bucaramanga", "Bucaramanga" },
                { "Junior", "Atletico Junior" },
                { "Fortaleza CEIF", "Fortaleza FC" },
                { "Independiente Santa Fe", "Santa Fe" },
                { "Rionegro Aguilas", "Aguilas Doradas Rionegro" },
                { "Envigado FC", "Envigado" },
                { "Boyaca Chico", "Chico FC" },
                { "Llaneros", "Llaneros FC" },
                { "Alianza Petrolera", "Alianza FC Valledupar" }
            };
        }
        else if (leagueName.Contains("Colombia Primera B", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Atlético", "Atletico FC" },
                { "Cucuta Deportivo", "Cucuta" },
                { "Internacional Palmira", "Internacional de Palmira" },
                { "Jaguares de Cordoba", "CD Jaguares" },
                { "Quindio", "Deportes Quindio" },
                { "Real Soacha", "Real Soacha Cundinamarca" }
            };
        }
        else if (leagueName.Contains("Costa Rica Primera Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "LD Alajuelense", "Alajuelense" },
                { "CS Herediano", "Herediano" },
                { "Saprissa", "Deportivo Saprissa" }
            };
        }
        else if (leagueName.Contains("Croatia 1.HNL", StringComparison.OrdinalIgnoreCase) ||
                 leagueName.Contains("Croatia 2. HNL", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Dinamo Zagreb", "GNK Dinamo Zagreb" },
                { "Rijeka", "HNK Rijeka" }
            };
        }
        else if (leagueName.Contains("Cyprus First Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "AEK Larnaca", "AEK Larnaca" }, // same, no alias
                { "AEL", "AEL Limassol" },
                { "Akritas", "Akritas Chlorakas" },
                { "APOEL", "APOEL Nicosia" },
                { "Apollon", "Apollon Limassol" },
                { "Aris", "Aris Limassol" },
                { "Digenis Ypsonas", "Ypsonas" },
                { "Enosis", "Enosis Paralimni" },
                { "Ethnikos Achna", "Ethnikos Achnas" },
                { "Olympiakos", "Olympiakos Nicosia" },
                { "Omonia Aradippou", "Omonia Aradippou" }, // same, no alias
                { "Omonia Nicosia", "Omonia Nicosia" }, // same
                { "Paphos", "Pafos FC" }
            };
        }
        else if (leagueName.Contains("Czech Republic 1. Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Baník Ostrava", "Banik Ostrava" },
                { "Mladá Boleslav", "Mlada Boleslav" },
                { "Sigma Olomouc", "SK Sigma Olomouc" },
                { "Slavia Praha", "Slavia Prague" },
                { "Sparta Praha", "Sparta Prague" },
                { "Viktoria Plzen", "Viktoria Plzen" }, // same spelling but confirm: CSV sometimes uses FC Viktoria Plzeň
                { "SK Dynamo Ceske Budejovice", "SK Dynamo Ceske Budejovice" } // identical, no alias needed normally
            };
        }
        else if (leagueName.Contains("Czech Republic Division 2", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Ceské Budejovice", "SK Dynamo Ceske Budejovice" },
                { "Chrudim", "MFK Chrudim" },
                { "Hanácká", "SK Hanacka Slavia Kromeriz" },
                { "Lisen", "SK Lisen" },
                { "Ostrava B", "Banik Ostrava B" },
                { "Slavia Praha II", "Slavia Prague B" },
                { "Táborsko", "FK MAS Taborsko" },
                { "Ustí nad Labem", "Usti nad Labem" }, // check case sensitivity but identical otherwise
                { "Viktoria Zizkov", "Zizkov" },
                { "Vlasim", "FC Vlasim" },
                { "Vysocina Jihlava", "Vysocina Jihlava" }, // identical, normally omit
                { "Zbrojovka Brno", "FC Zbrojovka Brno" }
            };
        }
        else if (leagueName.Contains("Denmark Superligaen", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "AGF Aarhus", "AGF" },
                { "Brondby", "Broendby IF" },
                { "FC Fredericia", "Fredericia" },
                { "Midtjylland", "FC Midtjylland" },
                { "Odense BK", "OB" },
                { "Sonderjyske", "SoenderjyskE" },
            };
        }
        else if (leagueName.Contains("Denmark Division 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

            };
        }
        else if (leagueName.Contains("Estonia Meistriliiga", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Flora", "Flora Tallinn" },
                { "Levadia", "FCI Levadia" },
                { "Nomme Kalju", "Nomme Kalju FC" },
                { "Paide", "Paide Linnameeskond" },
                { "Trans", "Narva Trans" },
                { "Vaprus", "Parnu JK Vaprus" },
                { "Tallinna Kalev", "Talinna Kalev" }
            };
        }

        else if (leagueName.Contains("Finland Veikkausliiga", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "FC Inter", "FC Inter Turku" },
                { "FC Ilves", "Ilves" },
                { "KuPS Kuopio", "KuPS" },
                { "SJK", "SJK-J" },
                { "VPS Vaasa", "VPS" },
                { "FC Haka", "FC Haka J" },
                { "KTP", "FC KTP" }
            };
        }
        else if (leagueName.Contains("Finland Ykkosliiga", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore (Ykkösliiga clubs; names vary a lot across data sources)
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Lahti", "FC Lahti" },
                { "JäPS", "JaePS" },
                { "SJK II", "SJK Akatemia" },
                { "KäPa", "KaPa Kapylan Pallo" },
                { "PK-35", "PK-35 Helsinki" },
                { "Klubi-04", "Klubi 04" }
            };
        }
        else if (leagueName.Contains("Germany Bundes II", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "1. FC Nuremberg" , "Nurnberg" },
                    { "Preussen Muenster","SC Preussen Munster" },
                    { "Karlsruher SC", "Karlsruhe" },
                    { "VfL Bochum", "Bochum" },
                    { "Schalke 04", "Schalke" }
                };
        }
        else if (leagueName.Contains("Greece Super League", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Aris Salonika", "Aris" },
                { "Atromitos Athinon", "Atromitos" },
                { "Kifisia", "Kifisia FC" },
                { "Larissa", "AE Larissa" },
                { "Panserraikos", "Panserraikos FC" },
                { "PAOK Salonika", "PAOK FC" },
                { "Volos NFC", "NFC Volos" }
            };
        }
        else if (leagueName.Contains("Holland Eerste Divisie", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Ajax Reserves", "Jong Ajax" },
                { "AZ Reserves", "Jong AZ Alkmaar" },
                { "PSV Reserves", "Jong PSV" },
                { "FC Utrecht Reserves", "Jong FC Utrecht" },
                { "Maastricht", "MVV Maastricht" },
                { "FC Oss", "TOP Oss" },
                { "RKC", "RKC Waalwijk" },
                { "Cambuur Leeuwarden", "Cambuur" },
                { "Roda JC", "Roda JC Kerkrade" }
            };
        }
        else if (leagueName.Contains("Holland Eredivisie", StringComparison.OrdinalIgnoreCase))
        {
            // CSV -> LiveScore
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "AZ", "AZ Alkmaar" },
                { "Heerenveen", "SC Heerenveen" },
                { "NAC", "NAC Breda" },
                { "NEC", "NEC Nijmegen" },
                { "PSV", "PSV Eindhoven" }
            };
        }
        else if (leagueName.Contains("Hungary NB II", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Iceland Pepsideild", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("India ISL", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Mumbai City", "Mumbai City FC" },
                { "ATK Mohun Bagan", "ATK Mohun Bagan" }
                // etc
            };
        }
        else if (leagueName.Contains("Ireland Division 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Wexford Youths", "Wexford FC" }
            };
        }
        else if (leagueName.Contains("Ireland Premier Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Bohemians Dublin", "Bohemian FC" },
                { "St Patricks", "St. Patrick's Athletic" },
            { "Galway United", "Galway United FC" }
            };
        }
        else if (leagueName.Contains("Israel Leumit League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Hapoel Acre", "Hapoel Ironi Akko" },
                { "Kafr Qasim", "SC Kfar Kasem" },
                { "Maccabi Petah Tikva", "Maccabi Petach Tikva" },
                { "Hapoel Nazareth Illit", "Hapoel Nof HaGalil" },
                { "Hapoel Ra'anana", "Hapoel Raanana" }
            };
        }
        else if (leagueName.Contains("Israel Ligat ha Al", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Ashdod", "FC Ashdod" },
                { "Hapoel Be'er Sheva", "Hapoel Beer Sheva" },
                { "Hapoel Katamon", "Hapoel Jerusalem" },
                { "Ironi Kiryat Shmona", "Hapoel Ironi Kiryat Shmona" },
                { "Maccabi Bnei Raina", "Maccabi Bnei Reineh" }
            };
        }
        else if (leagueName.Contains("Italy Serie B", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Reggiana", "AC Reggiana" },
                { "Padova", "Calcio Padova" },
                { "SÃ¼dtirol", "Sudtirol" }, // keep for normalization (LiveScore uses "Südtirol" with umlaut)
                { "Cesena", "Cesena FC" },
                { "Pescara", "Pescara Calcio" }
            };
        }
        else if (leagueName.Contains("Japan J-League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Nagoya Grampus", "Nagoya Grampus Eight" },
                { "Yokohama F-Marinos", "Yokohama F.Marinos" },
                { "Fagiano Okayama", "Fagiano Okayama FC" }
            };
        }
        else if (leagueName.Contains("Japan J2-League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Jordan Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Kazakhstan Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Astana", "FC Astana" },
                { "Yelimay Semey", "FC Yelimay" },
                { "Kyzyl-Zhar", "FC Kyzylzhar Petropavlovsk" },
                { "Okzhetpes", "Okzhetpes Kokshetau" },
                { "Kaisar", "Kaisar Kyzylorda" },
                { "Kairat", "Kairat Almaty" },
                { "Tobol", "Tobol Kostanay" },
                { "Ordabasy", "Ordabasy Shymkent" },
                { "Zhetysu", "Zhetysu Taldykorgan" },
                { "Turan", "FC Turan" }
            };
        }
        else if (leagueName.Contains("Kuwait Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Lithuania A Lyga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Kauno Zalgiris", "FK Kauno Zalgiris" },
                { "Panevezys", "FK Panevezys" },
                { "Siauliai", "FA Siauliai" },
                { "Zalgiris", "Zalgiris Vilnius" }
            };
        }
        else if (leagueName.Contains("Malaysia Super League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "DPMM FC", "Brunei DPMM" },
                { "Kuala Lumpur", "Kuala Lumpur City FC" },
                { "Kelantan United", "Kelantan The Real Warriors" }
            };
        }
        else if (leagueName.Contains("Malta Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Mexico Apertura", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Club America", "CF America" },
                { "Chivas Guadalajara", "CD Guadalajara" },
                { "Juarez FC", "FC Juarez" },
                { "Atletico San Luis", "Atletico de San Luis" },
                { "Unam Pumas", "Pumas" },
                { "Santos Laguna", "Club Santos Laguna" },
                { "Queretaro", "Queretaro FC" }
            };
        }
        else if (leagueName.Contains("Montenegro Prva Crnogorska Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Arsenal Tivat", "FK Arsenal Tivat" },
                { "Bokelj", "FK Bokelj" },
                { "Buducnost", "Buducnost Podgorica" },
                { "Decic", "Decic Tuzi" },
                { "Jedinstvo", "Jedinstvo BP" },
                { "Mladost DG", "OFK Mladost Donja Gorica" }
            };
        }
        else if (leagueName.Contains("Morocco Botola Pro", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Wydad AC", "Wydad AC" },
                { "Raja CA", "Raja Casablanca" }
            };
        }
        else if (leagueName.Contains("Northern Ireland NIFL Premiership", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Linfield", "Linfield FC" },
                { "Glentoran", "Glentoran FC" }
                // Add others if your CSV includes them
            };
        }
        else if (leagueName.Contains("Norway Eliteserien", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Bodoe/Glimt", "Bodo/Glimt" },
                { "Brann", "SK Brann" },
                { "Stroemsgodset", "Stromsgodset" },
                { "Vaalerenga", "Valerenga" },
                { "Viking", "Viking FK" }
            };
        }
        else if (leagueName.Contains("Norway Division 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Lillestrom", "Lillestroem" },
                { "Asane", "Aasane" },
                { "Hodd", "Hoedd" },
                { "Odd BK", "Odds Ballklubb" },
                { "Mjondalen", "Mjoendalen" }
            };
        }
        else if (leagueName.Contains("Paraguay Primera Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Atletico Tembetary", "Atlético Tembetary" },
                { "CD Recoleta", "Deportivo Recoleta" },
                { "Club General Caballero JLM", "General Caballero JLM" },
                { "Guarani", "Guaraní" },
                { "Luqueno", "Sportivo Luqueño" },
                { "Cerro Porteno", "Cerro Porteño" },
                { "Nacional Asuncion", "Nacional Asunción" }
            };
        }
        else if (leagueName.Contains("Peru Liga 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Universitario de Deportes", "Universitario" },
                { "Asociacion Deportiva Tarma", "AD Tarma" },
                { "Atletico Grau", "Atlético Grau" },
                { "Alianza Atletico", "Alianza Atlético" },
                { "ADC Juan Pablo II", "Juan Pablo II College" },
                { "CD UT Cajamarca", "UTC Cajamarca" },
                { "Binacional", "Deportivo Binacional" }
            };
        }
        else if (leagueName.Contains("Poland Ekstraklasa", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Cracovia", "Cracovia Krakow" },
                { "Legia Warszawa", "Legia Warsaw" },
                { "Rakow Czestochowa", "Rakow Czestochowa" },
                { "Termalica Nieciecza", "Termalica BB Nieciecza" }
            };
        }
        else if (leagueName.Contains("Poland I Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Portugal Primeira Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "SC Braga", "Braga" },
                { "Sporting CP", "Sporting" },
                { "Vitoria de Guimaraes", "Guimaraes" },
                { "CF Estrela da Amadora", "Estrela" },
                { "Casa Pia AC", "Casa Pia" },
                { "AVS Futebol SAD", "AVS" }
            };
        }
        
        else if (leagueName.Contains("Portugal Segunda Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Sporting CP B", "Sporting B" },
                { "FC Porto B", "Porto B" },
                { "Uniao de Leiria", "Leiria" },
                { "Academico Viseu", "Academico Viseu" }, // same, keep unchanged
                { "Pacos de Ferreira", "Pacos Ferreira" },
                { "Lusitania Lourosa", "Lusitania FC Lourosa" },
                { "Felgueiras 1932", "Felgueiras" },
                { "Chaves", "Desportivo Chaves" },
                { "Farense", "SC Farense" }
            };
        }
        else if (leagueName.Contains("Qatar QSL", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Al-Ahli", "Al Ahli" },
                { "Al-Arabi", "Al Arabi" },
                { "Al-Duhail SC", "Al Duhail" },
                { "Al-Gharafa", "Al Gharafa" },
                { "Al-Rayyan", "Al Rayyan" },
                { "Al-Sadd", "Al Sadd" },
                { "Al-Sailiya", "Al Sailiya" },
                { "Al-Shamal", "Al Shamal" },
                { "Al-Shahaniya", "Al Shahaniya" },
                { "Al-Wakra", "Al Wakrah" },
                { "Qatar SC", "Qatar SC" },
                { "Umm Salal", "Umm Salal" }
            };
        }
        else if (leagueName.Contains("Romania Liga I", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Botosani", "FC Botosani" },
                { "FC Rapid 1923", "Rapid Bucharest" },
                { "CS Universitatea Craiova", "U Craiova" },
                { "Dinamo Bucuresti", "Dinamo Bucharest" },
                { "ACS Champions FC Arges", "FC Arges" },
                { "FC Unirea 2004 Slobozia", "Unirea Slobozia" },
                { "Otelul Galati", "Otelul" },
                { "UTA Arad", "UTA Arad" },
                { "FCV Farul Constanta", "Farul Constanta" },
                { "Universitatea Cluj", "Universitatea Cluj" },
                { "FCSB", "FCSB" },
                { "CFR Cluj", "CFR Cluj" },
                { "Hermannstadt", "AFC Hermannstadt" },
                { "Petrolul Ploiesti", "Petrolul 52" },
                { "Miercurea Ciuc", "Csikszereda" },
                { "FC Metaloglobus Bucuresti", "Metaloglobus" }
            };
        }
        else if (leagueName.Contains("Romania Liga II", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Corvinul Hunedoara", "Corvinul Hunedoara" },
                { "FC Bihor Oradea", "FC Bihor" },
                { "Chindia Targoviste", "Chindia Targoviste" },
                { "ASA Targu Mures", "FC Targu Mures" },
                { "FC Voluntari", "FC Voluntari" },
                { "Steaua Bucuresti", "Steaua Bucuresti" },
                { "Concordia Chiajna", "CS Concordia Chiajna" },
                { "CSM Resita", "Scolar Resita" },
                { "Sepsi OSK", "ACS Sepsi" },
                { "CS Afumati", "Afumati" },
                { "CSM Politehnica Iasi", "CSMS Iasi" },
                { "Metalul Buzau", "Metalul Buzau" },
                { "Ceahlaul Piatra-Neamt", "FC Ceahlaul Piatra Neamt" },
                { "CSM Slatina", "CSM Slatina" },
                { "FC Bacau", "FC Bacau" },
                { "CSC Dumbravita", "Dumbrăvița" }, // dataset label slightly shortened / localized
                { "CS Dinamo Bucuresti", "CS Din. Bucuresti" },
                { "CS Tunari", "Tunari" },
                { "CS Gloria Bistrita", "Gloria Bistrita" },
                { "Comunal Selimbar", "Selimbar" },
                { "CSM Olimpia Satu Mare", "CSM Satu Mare" },
                { "Campulung Muscel", "Campulung" }
            };
        }
        else if (leagueName.Contains("Russia Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Spartak Moscow", "Spartak Moscow" },
                { "Zenit Saint Petersburg", "Zenit" }
            };
        }
        else if (leagueName.Contains("Russia FNL", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Saudi Arabia Saudi Professional", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Al Nassr", "Al Nassr" },
                { "Al Qadsiah", "Al Quadisiya" },
                { "Al Ittihad", "Al Ittihad" },
                { "NEOM SC", "NEOM SC" },
                { "Al Taawoun", "Al Taawon" },
                { "Al Hilal", "Al Hilal" },
                { "Al Ahli", "Al Ahli Jeddah" },
                { "Al Ettifaq", "Al Ittifaq" },
                { "Al Feiha", "Al Feiha" },
                { "Al Khaleej", "Al Khaleej" },
                { "Al Kholood", "Al Kholood" },
                { "Al Shabab", "Al Shabab" },
                { "Al Riyadh", "Al Riyadh" },
                { "Al Hazm", "Al Hazm" },
                { "Damac", "Dhamk" },
                { "Al Fateh", "Al Fateh" },
                { "Al Najma", "Al Najma" },
                { "Al Akhdoud", "Al Akhdoud" }
            };
        }
        else if (leagueName.Contains("Scotland Premiership", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Hearts", "Hearts" },
                { "Celtic", "Celtic" },
                { "Kilmarnock", "Kilmarnock" },
                { "Dundee United", "Dundee Utd" },
                { "St. Mirren", "St Mirren" },
                { "Motherwell", "Motherwell" },
                { "Hibernian", "Hibernian" },
                { "Rangers", "Rangers" },
                { "Livingston", "Livingston" },
                { "Falkirk", "Falkirk" },
                { "Dundee FC", "Dundee" },
                { "Aberdeen", "Aberdeen" }
            };
        }
        else if (leagueName.Contains("Scotland Championship", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "St. Johnstone", "St Johnstone" },
                { "Partick Thistle", "Partick" },
                { "Raith Rovers", "Raith" },
                { "Arbroath", "Arbroath" },
                { "Ayr United", "Ayr" },
                { "Greenock Morton", "Morton" },
                { "Dunfermline Athletic", "Dunfermline" },
                { "Queen's Park", "Queen's Park" },
                { "Ross County", "Ross County" },
                { "Airdrieonians", "Airdrieonians" }
            };
        }
        else if (leagueName.Contains("Scotland League One", StringComparison.OrdinalIgnoreCase) ||
                 leagueName.Contains("Scotland League Two", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Serbia Super Liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Partizan", "FK Partizan" },
                { "Red Star", "Red Star Belgrade" }
            };
        }
        else if (leagueName.Contains("Slovakia Fortuna liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "DAC 1904 Dunajska Streda", "DAC" },
                { "Zilina", "Zilina" },
                { "Slovan Bratislava", "Slovan Bratislava" },
                { "Zemplin Michalovce", "Zemplín Michalovce" },
                { "Spartak Trnava", "Spartak Trnava" },
                { "Trencin", "Trencín" },
                { "Zeleziarne Podbrezova", "Podbrezová" },
                { "Ruzomberok", "Ruzomberok" },
                { "Skalica", "Skalica" },
                { "Tatran Presov", "Tatran Presov" },
                { "Komarno", "Komarno" },
                { "FC Kosice", "Kosice" }
            };
        }
        else if (leagueName.Contains("Slovenia Prva liga", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "NK Celje", "Celje" },
                { "Maribor", "Maribor" },
                { "NK Bravo", "Bravo" },
                { "Koper", "Koper" },
                { "Olimpija Ljubljana", "Olimpija" },
                { "Aluminij", "Aluminij" },
                { "Radomlje", "Radomlje" },
                { "Primorje", "Primorje" },
                { "Mura", "Mura" },
                { "Domzale", "Domzale" }
            };
        }
        else if (leagueName.Contains("South Africa Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Mamelodi Sundowns FC", "Mamelodi Sundowns" },
                { "Sekhukhune United", "Sekhukhune" },
                { "Orlando Pirates", "Orlando Pirates" },
                { "Durban City F.C", "Durban City" },
                { "Kaizer Chiefs", "Kaizer Chiefs" },
                { "Polokwane City", "Polokwane City" },
                { "TS Galaxy", "TS Galaxy" },
                { "Lamontville Golden Arrows", "Golden Arrows" },
                { "AmaZulu FC", "AmaZulu" },
                { "Richards Bay", "Richards Bay" },
                { "Marumo Gallants", "Tshakhuma" }, // dataset uses legacy name
                { "Siwelele F.C.", "Siwelele" },
                { "Orbit College", "Orbit College" },
                { "Stellenbosch FC", "Stellenbosch" },
                { "Magesi FC", "Magesi" },
                { "Chippa United", "Chippa United" }
            };
        }
        else if (leagueName.Contains("South Korea K League 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Jeonbuk", "Jeonbuk Hyundai" }
            };
        }
        else if (leagueName.Contains("South Korea K League 2", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Bucheon FC 1995", "Bucheon 1995" },
                { "Gimpo FC", "Gimpo C." },
                { "Seoul E-Land FC", "Seoul E." },
                { "Chungnam Asan FC", "Asan Mugunghwa" }
            };
        }
        else if (leagueName.Contains("Spain Segunda", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "AD Ceuta FC", "Ceuta" },
                { "Castellon", "CD Castellon" },
                { "Cultural Leonesa", "Leonesa" }, // same but dataset uses full "Cultural Leonesa"
                { "R. Sociedad B", "Real Sociedad B" },
                { "Huesca", "SD Huesca" },
                { "Real Valladolid", "Valladolid" }
            };
        }
        else if (leagueName.Contains("Sweden Allsvenskan", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Mjaellby", "Mjallby AIF" },
                { "Djurgaarden", "Djurgarden" },
                { "BK Haecken", "BK Hacken" },
                { "IFK Gothenburg", "IFK Goteborg" },
                { "IFK Norrkoeping", "IFK Norrkoping" },
                { "Oesters IF", "Osters IF" },
                { "Vaernamo", "IFK Varnamo" }
            };
        }
        else if (leagueName.Contains("Sweden Superettan", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Oergryte", "Orgryte IS" },
                { "Vasteraas SK", "Västerås SK FK" },
                { "Oestersunds FK", "Ostersunds FK" },
                { "Umeaa", "Umea FC" },
                { "IK Oddevold", "Oddevold" },
                { "Sandvikens IF", "Sandviken" }
            };
        }
        else if (leagueName.Contains("USA MLS", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "LA Galaxy", "LA Galaxy" }
            };
        }
        else if (leagueName.Contains("Wales Cymru Premier", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "TNS", "The New Saints" },
                { "Penybont", "Penybont" },
                { "Caernarfon", "Caernarfon Town" },
                { "Connah's Quay", "Connah's Quay" },
                { "Colwyn Bay", "Colwyn Bay" },
                { "Bala Town", "Bala Town" },
                { "Barry Town", "Barry Town United" },
                { "Cardiff Met University", "Cardiff MU" },
                { "Briton Ferry", "Briton Ferry" },
                { "Flint Town United", "Flint Town United" },
                { "Haverfordwest", "Haverfordwest County" },
                { "Llanelli", "Llanelli Town" }
            };
        }
        else if (leagueName.Contains("Switzerland Super League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Thun", "FC Thun" },
                { "Sion", "FC Sion" },
                { "Luzern", "Lucerne" },
                { "Grasshopper", "Grasshoppers" },
                { "Lausanne", "Lausanne Sports" },
                { "FC Zurich", "FC Zurich" }, // kept identical for completeness
                { "St. Gallen", "St Gallen" }  // dot removed for normalization
            };
        }
        else if (leagueName.Contains("Switzerland Challenge League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Etoile Carouge", "Étoile Carouge" },
                { "FC Wil 1900", "Wil 1900" },
                { "Xamax", "Neuchatel Xamax" },
                { "FC Stade Lausanne-Ouchy", "Stade Lausanne-Ouchy" }
            };
        }
        else if (leagueName.Contains("Thailand Thai League 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "BG Pathum United", "Bangkok Glass" },
                { "Kanchanaburi Power", "Kanchanaburi" },
                { "Ayutthaya United FC", "Ayutthaya United" },
                { "Prachuap FC", "Prachuap" },
                { "Rayong FC", "Rayong" },
                { "Ratchaburi FC", "Ratchaburi" },
                { "Uthai Thani FC", "Uthai Thani" },
                { "Nakhon Ratchasima FC", "Nakhon Ratchasima" }
            };
        }
        else if (leagueName.Contains("Turkey Super Lig", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Galatasaray", "Galatasaray" },
                { "Fenerbahçe", "Fenerbahce" },
                { "Beşiktaş", "Besiktas" }
            };
        }
        else if (leagueName.Contains("Turkey 1. Lig", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
            {
                { "Bodrum FK", "Bodrumspor" },
                { "Corum FK", "Çorum Belediyespor" },
                { "Esenler Erokspor", "Erokspor" },
                { "Erzurum FK", "Erzurum BB" },
                { "Igdir FK", "Igdir FK" }, // identical, included for completeness
                { "Keciorengucu", "Keçiörengücü" },
                { "Manisa FK", "Manisa FK" }, // identical
                { "Sariyer", "Sar?yer" },
                { "Umraniyespor", "Ümraniyespor" },
                { "Van Spor Kulubu", "Van BB" }
            };
        }
        else if (leagueName.Contains("Ukraine Premier League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Cherkasy", "LNZ Cherkasy" },
                { "Epicentr Kamianets-Podilskyi", "Epitsentr Dunayivtsi" },
                { "FC Kolos Kovalivka", "Kolos Kovalivka" },
                { "FC Obolon Kyiv", "Obolon" },
                { "FC Olexandriya", "Oleksandria" },
                { "Polissya Zhytomyr", "Zhytomyr" },
                { "Rukh Lviv", "Rukh Vynnyky" },
                { "Shakhtar Donetsk", "Shakhtar Donetsk" }, // identical
                { "Dynamo Kyiv", "Dynamo Kyiv" }, // identical
                { "Zorya", "Zorya" }, // identical
                { "Karpaty", "Karpaty" }, // identical
                { "Kudrivka", "Kudrivka" }, // identical
                { "SC Poltava", "SC Poltava" }, // identical
                { "Veres Rivne", "Veres" },
                { "Metalist 1925", "Metalist 1925" },
                { "Kryvbas", "Hirnyk" }
            };
        }
        else if (leagueName.Contains("United Arab Emirates UAE League", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Al Ittihad Kalba", "Al Ittihad Kalba" }, // identical
                { "Al-Jazira", "Al Jazira" },
                { "Al-Nasr SC", "Al Nasr" },
                { "Al-Wahda", "Al Wahda" },
                { "Al-Wasl", "Al Wasl" },
                { "Baniyas", "Bani Yas" },
                { "Dibba Al Fujairah", "Dibba Al Fujairah" },
                { "Khorfakkan", "Khorfakkan Club" },
                { "Sharjah Cultural Club", "Al Sharjah" },
                { "Shabab Al-Ahli Dubai FC", "Shabab Al Ahli Dubai" },
                { "Al-Dhafra", "Al Dhafra" },
                { "Al Bataeh", "Al Bataeh" },
                { "Ajman", "Ajman" },
                { "Al-Ain", "Al Ain" }
            };
        }
        else if (leagueName.Contains("Uruguay Primera Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Club Atletico Penarol", "Peñarol" },
                { "Nacional", "Nacional" },
                { "Montevideo City Torque", "Torque" },
                { "Boston River", "Boston River" },
                { "Defensor Sporting", "Defensor Sporting" },
                { "Liverpool FC", "Liverpool" },
                { "Cerro Largo", "Cerro Largo" },
                { "Club Atletico Progreso", "Progreso" },
                { "Danubio", "Danubio" },
                { "Cerro", "Cerro" },
                { "Miramar Misiones", "Miramar Misiones" },
                { "Juventud de las Piedras", "Juventud" },
                { "Racing", "Racing" },
                { "Plaza Colonia", "Plaza Colonia" },
                { "Montevideo Wanderers", "Wanderers" },
                { "River Plate", "River Plate" }
            };
        }
        else if (leagueName.Contains("USA MLS", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "LA Galaxy", "LA Galaxy" },
                { "New York City", "New York City FC" }
            };
        }
        else if (leagueName.Contains("USA USL Championship", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { };
        }
        else if (leagueName.Contains("Venezuela Primera Division", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Caracas", "Caracas FC" }
            };
        }
        else if (leagueName.Contains("Vietnam V.League 1", StringComparison.OrdinalIgnoreCase))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Phu Dong FC", "Phu Dong" },
                { "Cong An Ha Noi", "Cong An" },
                { "Ho Chi Minh City FC", "Ho Chi Minh City" },
                { "Viettel", "Viettel" },
                { "Hai Phong", "Hai Phong" },
                { "Ha Noi FC", "Ha Noi" },
                { "Hong Linh Ha Tinh", "Hong Linh Ha Tinh" },
                { "Nam Dinh", "Nam Dinh" },
                { "PVF-CAND", "Pho Hien" },
                { "Song Lam Nghe An", "Song Lam Nghe An" },
                { "Da Nang", "Da Nang" },
                { "Binh Duong", "Binh Duong" },
                { "Hoang Anh Gia Lai", "Hoang Anh Gia Lai" },
                { "Dong A Thanh Hoa", "FLC Thanh Hoa" }
            };
        }
        else
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }
    }
}
