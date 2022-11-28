#include <stdio.h>
#include <string.h>

int main(){
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
    printf("Enter the information of car %d:\n", i+1);
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
      if (strlen(cars[j].name) > strlen(cars[i].name)) {
        carr = cars[i];
        cars[i] = cars[j];
        cars[j] = carr;
      }
    }
  }

  printf("Information of cars: \n");
  for (int i = 0; i < size; i++) {
    printf("Car %d:\n", i+1);
    printf("-Name: %s\n", cars[i].name);
    printf("-Color: %s\n", cars[i].color); 
    printf("-Price: %d\n", cars[i].price);
  }
}

