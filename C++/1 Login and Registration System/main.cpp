#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    cout << "Welcom, You cdan 1 register or 2 login." << endl;
    int choice;
    string username, password, un, pw;
    cout << "Enter an option" << endl;
    cin >> choice;

    if (choice == 1)
    {
        cout << "Enter your username: " << endl;
        cin >> username;
        cout << "Enter your password: " << endl;
        cin >> password;

        ofstream credFile("Credentials.txt");
        credFile << username << endl << password;
        credFile.close();

        cout << "U are registered!" < < < endl;
        main();
    }

    cout << "Login" << endl;
    cout << "Enter your username:" << endl;
    cin >> username;
    cout << "Enter your password:" << endl;
    cin >> password;

    ifstream readCredFile("Credentials.txt");
    getline(readCredFile, un);
    getline(readCredFile, pw);

    if (un == username && pw == password){
        cout << "Welcome: " << username << " How do you want to start your day. . .\n";
    }
    else{
        cout << "Wrong credentials" << endl;
        system("PAUSE");
        return 0;
    }
}