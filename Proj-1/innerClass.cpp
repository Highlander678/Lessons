#include <iostream>
#include<string>
using namespace std;
//создать внешний Image и внутренний класс Pixel
//Массив объектов класса

class Human {

public:
	void think()
	{
		brain.calc();
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
};


int main()
{
	Human Alex;
	setlocale(LC_ALL, "ru");
	Alex.think();

	system("pause");
	return 0;
}