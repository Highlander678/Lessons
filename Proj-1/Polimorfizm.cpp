#include<iostream>
#include<string>
//Полиморфизм
using namespace std;

class Gun {
public:
	Gun() {
	}
	virtual void Shoot()
	{
		cout << "Bang" << endl;
	}
};

class SubmachineGun : public Gun
{
public:
	SubmachineGun()
	{

	}
	void Shoot() override
	{
		cout << "Bang Bang Bang" << endl;
	}

};

int main()
{
	Gun pistolet;
	SubmachineGun bazuka;
	
	Gun *weapon = &pistolet;
	weapon->Shoot();

	//pistolet.Shoot();
	//bazuka.Shoot();


	system("pause");
	return 0;
}