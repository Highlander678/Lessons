#include <iostream>
#include<string>
using namespace std;
//������� ������� Image � ���������� ����� Pixel
//������ �������� ������
class Cap {
public:
	Cap()
	{
		this->colour= "�����";
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
		cout << "���� ����� " + cap.returnCapColour + endl;
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
			cout << "����� X++ = " << x << endl;
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