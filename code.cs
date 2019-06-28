//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public int[] SelectMeals(int[] protein, int[] carbs, int[] fat, string[] dietPlans)
        {
            int len = protein.Length,len1=dietPlans.Length;
            int[] ans = new int[len1];
            int[] cal = new int[len];

            for(int i=0;i<len;i++){
                cal[i]= (protein[i] + carbs[i])*5 + fat[i]*9;
                
            }

            for(int i=0;i<len1;i++){
                int slen = dietPlans[i].Length;
                int[] visited  = new int[len];

                for(int j=0;j<len;j++){
                visited[j]=1;
                }

                for(int j=0;j<slen;j++){

                    if(dietPlans[i][j]=='p'){
                        Checkmin(protein,visit);
                    }
                    if(dietPlans[i][j]=='P'){
                        Checkmax(protein,visit);
                    }
                    if(dietPlans[i][j]=='c'){
                        Checkmin(carbs,visit);
                    }
                    if(dietPlans[i][j]=='C'){
                         Checkmax(carbs,visit);
                    }
                    if(dietPlans[i][j]=='f'){
                        Checkmin(fat,visit);
                    }
                    if(dietPlans[i][j]=='F'){
                         Checkmax(fat,visit);
                    }
                    if(dietPlans[i][j]=='t'){
                        Checkmin(cal,visit);
                    }
                    if(dietPlans[i][j]=='T'){
                         Checkmax(cal,visit);
                    }
                    ans[i]=check(visited);
                }

            }

            return ans;
            throw new NotImplementedException();
        }

        public static void Checkmin(int[] nut,int[] visit){
            int min=2000,len=nut.Length;
            for(int k=0;k<len;k++){
                if(nut[k]<min && visit[k]==1){
                    min = nut[k];
                }
            }

            for(int k=0;k<len;k++){
                if(nut[k]==min)
                    visit[k]=1;
                else
                    visit[k]=0;
            }
        }

        public static void Checkmax(int[] nut,int[] visit){
            int max=0,len=nut.Length;
            for(int k=0;k<len;k++){
                if(nut[k]>max && visit[k]==1){
                    max = nut[k];
                }
            }

            for(int k=0;k<len;k++){
                if(nut[k]==max)
                    visit[k]=1;
                else
                    visit[k]=0;
            }
        }

        public static int check(int[] visit){
            for(int i=0;i<visit.Length;i++){
                if(visit[i]==1)
                    return i;
            }
            return 0;;
        }

            
            
            
            
           /* int items=protein.Length;
            int le=dietPlans.Length;
            int [] result=new int[le];
            int [] calo=new int[items];
           
                for(int j=0;j<items;j++)
                {
                    calo[j]=(protein[j]+carbs[j])*5+fat[j]*9;
                }
           // for(int j=0;j<items;j++)
             //   {
               //     Console.WriteLine(calo[j]);
                //}
            
            int l=dietPlans.Length;
            for(int i=0;i<l;i++)
            {
                string s=dietPlans[i];
                for(int k=0;k<s.Length;k++)
                {
                    char c=s[k];
                    if(c=='t')
                    {
                        
            }
        }*/
        
        public static void Main(string[] args)
        {
            //Your code goes here
            Program p=new Program();
            int [] protein=new int[] {3, 4, 1, 5};
            int [] carbs=new int[] {2, 8, 5, 1};
            int [] fat=new int[] {5, 2, 4, 4};
            string [] dietPlans=new string[]{"tFc", "tF", "Ftc"};                      
            int[] res=p.SelectMeals(protein,carbs,fat,dietPlans);
            //Console.WriteLine(res[0]);
        }
    }
}