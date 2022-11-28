#include <stdio.h>

void menu(){
  printf("*****************************\n");
  printf("*Select an appropriate:     *\n");
  printf("*      1. R1                *\n");
  printf("*      2. R2                *\n");
  printf("*      3. R3                *\n");
  printf("*****************************\n");
}

void R1(){
  int num, size = 0;

   printf("How many numbers you want to enter: ");
  scanf("%d", &size);
  for (int i = 0; i < size; i++) {
   printf("Enter number: ");
   scanf("%d", &num);
  if (num > 0 ) {
    printf("Square: %d\n", num * num); 
  }  
}

}

void R2(){
  struct car
  {
    char name[20];
    char color[20];
    int price;
  };
  
  int size;
  printf("Enter the number of cars: \n");
  scanf("%d", &size);

  struct car cars[size];

  for (int i = 0; i < size; i++) {
    fflush(stdin);
    printf("Enter the information of car %d:\n", i);
    printf("Name: ");
    gets(cars[i].name);
    printf("Color: ");
    gets(cars[i].color);
    printf("Price: ");
    scanf("%d", &cars[i].price);
  }

  struct car carr;
  for (int i = 0; i < size; i++) {
    for (int j = i+1; j < size; j++) {
      if (cars[j].price > cars[i].price) {
        carr = cars[i];
        cars[i] = cars[j];
        cars[j] = carr;
      }
    }
  }

  printf("Information of cars: \n");
  for (int i = 0; i < size; i++) {
    printf("Car %d:\n", i);
    printf("-Name: %s\n", cars[i].name);
    printf("-Color: %s\n", cars[i].color); 
    printf("-Price: %d\n", cars[i].price);
  }
  
}

void R3(){
  printf("Exit program\n");
}

int main(){
  int cases;
  do
  {
    menu();
    printf("Input your cases: \n");
    scanf("%d", &cases);
    printf("----------\n");

    switch (cases) {
      case 1:
        R1();
        break;
      case 2:
        R2();
        break;
      case 3: 
        R3();
        break;
      default:
        printf("Invalid, choose 1-3 please\n");
        break;
    }
  } while(cases != 3);
}
