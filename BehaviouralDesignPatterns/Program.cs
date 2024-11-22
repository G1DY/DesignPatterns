using BehaviouralDesignPatterns.Observer.GoodSln;

var dataSource = new DataSource();
var sheet2 = new Sheet2(dataSource);
var barChart = new BarChart(dataSource);

dataSource.AddObserver(sheet2);
dataSource.AddObserver(barChart);
dataSource.SetValues([5,10,15,20]);
