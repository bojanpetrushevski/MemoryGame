# Memory Game

Проектна задача по предметот Визулено програмирање изработена од:
- Бојан Петрушевски 171134

## За играта:
Оваа апликација е едноставна имплементација на познатата игра со картички – меморија. Може да се најде под името Memory matching game или едноставно Memory game. Функционалноста на играта е едноставна, играчот секој потег отвора по две картички за кои смета дека имаат иста слика, т.е. пробува на спари две исти картички. Играта завршува кога сите картички ќе бидат спарени. Постојат три категории на кои може да да се игра. Тоа е всушност колку картички ќе содржи играта. Секоја категорија е именувана како m x n, каде m претставува бројот на редици во таблата со картички (во колку редици ќе бидат распоредени картичките), а n претставува колку картички ќе има во секоја редица (во колку колони ќе бидат распоредени картичките). Категориите кои постојат се **4 x 4**, **4 x 5** и **4 x 6**. Соодветно, бројот на картички за секоја категорија е 16, 20 и 24. Апликаицјата нуди два мода на играње, т.е. singleplayer mode и multiplayer mode. Доколку играчот избере да игра singleplayer mode, и покрај тоа што целта на играта е да се спарат сите картички, за време на играта ќе има часовник кој одбројува колку секунди се поминати од почетокот на играта. Играчот треба да се потруди да ја заврши играта за што е можно помалку време. Тоа ја прави играта покомпетитивна за играње. Откако играчот ќе заврши и дококу е помеѓу најдобрите 5 досегашни резултати **за соодветната категорија**, неговиот резултат ќе биде запишан во табелата со најдобри резултати за таа категорија во која играл играчот. Тоа значи дека за секоја од трите категории постои посебна табела со резултати (best scores). **Best scores функционалноста важи само за singleplayer mode**. Доколку има два играчи кои сакаат да играат еден против друг, може да играат multiplayer mode. Кај овој мод не постои никаков часовник кој одбројува колку време е поминато од почетокот на играта, туку се води само евиденција по колку парови од картички земал секој играч. Откако ќе се спарат сите картички, победник е оној играч кој има спарено повеќе картички. Ако се случи двајцата играчи да имаат спарено по ист број на картички, играта ќе заврши нерешено. Кај овој мод не е овозможена функционалноста за најдобри резултати, туку е само еден поопуштен 
friendly competitive mode. 

![Alt text](MemoryGame/screenshots/mainmenu_sc.jpg?raw=true "Main menu")

## Решение на проблемот (организација на податоци):
За оваа апликација е искористен голем број на класи кои што се добро органзирани и секоја од нив си има исклучиво своја функционалност. Бизнис логиката на играта е содржана во класите **Card** и **Game**. Класата **Card** е класа која репрезентира една картичка во играта меморија. За секоја картичка се чуваат **сликата на картичката (Bitmap)**, **рамката на картичката, т.е. самото поле кое го опфаќа картичката (PictureBox)**, **широчината на картичката во пиксели (int)**, **висината на картичката во пиксели (int)**, **почетната и мометалната позадинска боја (Color)**, **дали е отворена (bool)** и **дали е спарена со некоја друга картичка (bool)**. Оваа класа содржи методи за отворање/затворање на картичката, менување на позадинска боја, итн. Класата **Game** е основна (базна) класа од која изведуваат класите SingleplayerGame и MultiplayerGame. Ја содржи целокупната логика за играње меморија. Како свои податочни членови доволно е да се спомене дека чува **листа од картички (List/Card>)** и **бројот на отворени картички (int)**. Од оваа класа изведуваат класите **SingleplayerGame** и **MultiplayerGame**. Класата **SingleplayerGame** содржи објект од класата **Player**, додека класата **MultiplayerGame** содржи три објекти од класата **Player**, еден за првиот играч, еден за вториот играч и еден објект кој во секој момент содржи рефернца на еден од претходните два објекти, т.е. го претставува играчот кој е моментално на потег за играње. На тој начин полесно се манипулира со податоците. Класата која ја контролира целата игра, но и истовремено е форма која се прикажува на екран за време на играње на играта е класата **Scene**. Таа е само една основна класа од која наследуваат две други класи форми: **SingleplayerScene и **MulitplayerScene**. Во зависност од модот за играње, т.е. дали играчот избрал singleplayer или multiplayer, се повикува соодветната форма. И двете класи содржат методи за настаните кои се повикуваат при соодветна акција на корисникот, додатни методи, како и податочни членови за секој од двата мода на играње. Исто така, важни класи се класите кои играат улога во запишување на најдобрите резултати. Класата **Score** содржи податоци за еден резултат од една игра. Како свои податочни членови чува **играч кој го постигнал тој резултат (Player)**, **времето за кое играчот успеал да ја заврши играта во секунди (int)** и **датумот на кој ја завршил играта (Date)**. Класата **BestScoresData** содржи три податочни структири (SortedSet<Score>), за секоја од трите категории посебно. Искористено е SortedSet<Score> бидејќи оваа структура ги чува елемените сортирани, т.е. во истиот редослед како што и се прикажуваат во табелата со најдобри резултати. Класата форма која ги прикажува резултатите е **BestScores**. Поради причини со поврзување на останатите форми и статички методи на оваа класа, искористен е шаблонот Singleton. Класите задолжени за читање и запишување на најдобрите резултати во датотеки се **DataReader** и **DataWriter**.
  
## Код од некои од методите потребни за описот на методот подолу:
```
private void pb_MouseClick(object sender, EventArgs e)
{
    if (Game.Blocked)
        return;
    if(Game.OpenCard((PictureBox)sender))
        if (Settings.Sound)
            PlaySound(Resources.select_sound);
    Pair pair = Game.CheckPair();
    if (pair == null)
        return;
    if (pair.ValidPair)
    {
        if(Settings.Sound)
            PlaySound(Resources.correct_sound);
        Game.Hit(pair.Card1, pair.Card2);
        Game.UpdateOpenCards();
        Game.UpdatePairs();
        UpdateStats();
        if (Game.IsGameOver())
        {
            StopTimer();
            CheckScore();
        }
    }
    else
    {
        Game.Miss(pair.Card1, pair.Card2);
    }
}

public bool OpenCard(PictureBox clickedFrame)
{
    foreach (Card c in Cards)
        if(!c.IsOpen)
            if (c.ImageFrame == clickedFrame)
                return c.Toggle();
    return false;
}

public Pair CheckPair()
{
    Card c1 = null;
    Card c2 = null;
    bool validPair = false;
    foreach (Card c in Cards)
        if (!c.Paired && c.IsOpen)
            if (c1 == null)
                c1 = c;
            else
                c2 = c;
    if (c1 == null || c2 == null)
        return null;
    if (CheckEqualCards(c1, c2))
        validPair = true;
    return new Pair(c1, c2, validPair);
}

public void CheckScore()
{
    string message = null;
    SortedSet<Score> scores = null;
    if (Settings.SelectedCategory.Columns == 4)
        scores = BestScoresData.Best4x4;
    if (Settings.SelectedCategory.Columns == 5)
        scores = BestScoresData.Best4x5;
    if (Settings.SelectedCategory.Columns == 6)
        scores = BestScoresData.Best4x6;
    if (ScoreValidation.ValidateScore(scores, Game.Player.ElapsedTime))
    {
        EnterScore = new EnterScore(scores, Game.Player.ElapsedTime);
        EnterScore.ShowDialog();
        message = "Congrats, your score has been recorded in best scores";
    }
    else
    {
        message = "Sorry, not good enough for best scores";
    }
    PlayAgain(message);
}


public void PlayAgain(string message)
{
    PlayAgain playAgain = new PlayAgain(this, MainMenu, message);
    playAgain.ShowDialog();
}
```
## Детален опис на метод:
Метод кој контролира најмногу други методи и манипулира податоци е методот кој се повикува при клик на маусот врз некоја картичка. Методот е **pb_MouseClick**. Го има и во класата **SingleplayerScene** и во класата **MultiplayerScene**, бидејќи двата мода се играат на различни форми кои наследуваат од формата **Scene**. Овде ќе биде опишан само методот од класата **SingleplayerScene (методот прикажан погоре)**. Битно е дека оваа класа како свои податочни членови чува реферeнца од класата **Game** и референца од класата **GameSettings**. Прво се проверува дали играта е блокирана (дали има картички кои што само што биле отворени и треба да се почека 500 милисекунди да се затворат). Доколку е тоа точно, методот завршува и не прави ништо. Потоа се пробува да се отвори една карта, доколку отворањето е успешно, т.е. картата успеала да биде отворена, картата ќе се отовори и играчот ќе може да слушне соодветен звук за отворање на карта (освен ако играчот не ја оневозможил таа функционалност во опциите во главното мени). Потоа се проверува дали оваа картичка е пар со друга отоворена картичка (во еден момент може да има најмногу две отворени картички). Тоа го проверува методот CheckPair() кој ќе врати null ако на полето има отворено помалку од две картички или ќе врати објект од класата Pair во спротивно. Тој објект содржи член ValidPair кој е true ако парот содржи две исти картички, инаку е false. **Доколку парот не е валиден, немаме погодок на две исти картички, се повикува метод кој чека 500 милисекунди за да му дозволи на играчот да ги види картичките и потоа ги затвора истите**.**Доколку парот е валиден, значи имаме погодок на две исти картички**. Во тој случај играчот ќе слушне соодветен звук за погодак на две исти карти (освен ако играчот не ја оневозможил таа функционалност во опциите во главното мени). Потоа се повикува методот Hit од класата Game кои ги обележува двете картички како спарени и веќе нема да можат да бидат сменети (отворени). Потоа се ажурира бројот на отоворени картички, т.е. се зголемува за 2. Се зголемува и бројот на парови кои играчот ги има погодено. Се ажурираат и податоците кои се рендерираат на екранот за часовникот и паровите. Финално, овој метод проверува дали играта е завршена, т.е. дали сите картички се спарени. Доколку е завршена се стопира часовникот и се проверува дали овој резултат е помеѓу најдобрите 5 во категоријата за да биде запишан.

## Screenshots од апликацијата:
![Alt text](MemoryGame/screenshots/singleplayer_mode_sc.jpg?raw=true "Singleplayer mode")
![Alt text](MemoryGame/screenshots/multiplayer_mode_sc.jpg?raw=true "Multiplayer mode")
![Alt text](MemoryGame/screenshots/best_scores_4x4_sc.jpg?raw=true "Best scores 4x4 category")
