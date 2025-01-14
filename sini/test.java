package matric;

public class test {
static int MS=5;
static void print(int mat[][]){
	
	
	
	
	
	
	
	
	
	
	
	for(int i=0;i<MS;i++){
		for(int j=0;j<MS;j++)
			System.out.printf("%4d",mat[i][j]);
		System.out.println();}
}
static void func(int mat[][]){
	
int a,b,c,d;
	for(int p=0;p<MS/2;p++)
		for(int q=p;q<MS-p-1;q++){
			a=mat[p][q];
			b=mat[q][MS-p-1];
			c=mat[MS-p-1][MS-q-1];
			d=mat[MS-q-1][p];
			mat[p][q]=d;
			mat[q][MS-p-1]=a;
			mat[MS-p-1][MS-q-1]=b;
			mat[MS-q-1][p]=c;
		}
}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
int mat[][]=new int [MS][MS];
for(int i=0;i<MS;i++)
	for(int j=0;j<MS;j++)
		mat[i][j]=i;
func(mat);
print(mat);
	}

}
