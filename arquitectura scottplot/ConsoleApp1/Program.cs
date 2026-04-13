using ScottPLot;

ScottPlot.Plot.myPLot =new();

///create sample data

double[] datax = { 1, 2, 3, 4, 5 };
double[] datay= {1,4,9,16,25};

//add a scatter plot to the plot

myplot.Add.scatter(datay,datax);

ScottPlot.PLot myPLot = new();
myPLot.title("Mi primer scatter");

myPLot.savePng("demo_invertido.png",400,300);   
