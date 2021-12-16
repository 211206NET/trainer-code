using UI;
using DL;

//Dep Injection
IRepo repo = new FileRepo();
RRBL bl = new RRBL(repo);
MainMenu menu = new MainMenu(bl);

menu.Start();