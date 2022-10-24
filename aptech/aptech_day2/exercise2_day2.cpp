#include <stdio.h>

int main(){
  int number_of_month;

  printf("Enter your month number(from 1 to 12 months):\n");
  scanf("%d", &number_of_month);

  if(number_of_month >= 1 && number_of_month <= 3 ){
    printf("month %d is the first quarter of thed year. \n", number_of_month);
  }else if (number_of_month <= 6) {
    printf("month %d is the second quarter of the year. \n", number_of_month); 
  }else if (number_of_month <= 9) {
    printf("month %d is the third quarter of the year. \n", number_of_month);
  }else if (number_of_month <=12) {
    printf("month %d is the fourth quarter of the year. \n", number_of_month);
  }else{
    printf("Go back to 1st grade, what are you writing? (>‿<)\n");
  }
}

