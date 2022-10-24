#include <stdio.h>

  int main(){
	int year;
	
	printf("input year: ");
	scanf("%d", &year);
	
	if(year % 100 == 0){
    if (year % 400 == 0) {
      printf("%d is a leap year. \n", year);
    }else{
      printf("%d is not a leap year. \n", year);
    }
	}else {
	 if (year % 4 == 0) {
      printf("%d is a leap year. \n", year);
    }else{
      printf("%d is not a leap year. \n", year);
    }
	}
}




//Lunar calendar:
/*
int main(){
  int number_of_year, leap_year;

  printf("Input number_of_year: \n");
  scanf("%d", &number_of_year);

  leap_year = number_of_year % 19;

  if (leap_year == 0 || leap_year == 3 || leap_year == 6 || leap_year == 9 || leap_year == 11 || leap_year == 14 || leap_year == 17) {
    printf("%d is a leap year. \n", number_of_year);
  }else{
    printf("%d is not a leap year. \n", number_of_year);
  }
}
*/
