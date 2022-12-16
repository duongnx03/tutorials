//
//  main.m
//  function file in C
//
//  Created by mac on 11/7/22.
//

#include <stdio.h>
#include <string.h>

int main()
{

   char buff[1024];
   
   memset( buff, '\0', sizeof( buff ));
   
   fprintf(stdout, "Chuan bi buffer\n");
   setvbuf(stdout, buff, _IOFBF, 1024);

   fprintf(stdout, "Hoc C co ban va nang cao tai QTM !!!\n");
   fprintf(stdout, "Ket qua nay se duoc dem\n");
   fflush( stdout );
   
   return(0);
}
