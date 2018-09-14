#include <iostream>
#include<string>
using namespace std;
//создать внешний Image и внутренний класс Pixel
//Массив объектов класса
class Cap {
public:
	Cap()
	{
		this->colour= "синий";
	}
	string returnCapColour() {
		return this->colour;
	}
private:
	string colour;
};
class Human {

public:
	void think()
	{
		brain.calc();
	}
	void ChackCapColour()
	{
		cout << "Цвет кепки " + cap.returnCapColour + endl;
	}
private:
	class Brain {

	public:
		Brain()
		{
			x = 0;
		}
		void calc()
		{
			x++;
			cout << "Думаю X++ = " << x << endl;
		}
	private:
		int x;
	};
	Brain brain;
	Cap cap;
	
};


int main()
{
	Human Alex;
	setlocale(LC_ALL, "ru");
	Alex.think();
	Alex.ChackCapColour();
	system("pause");
	return 0;
}