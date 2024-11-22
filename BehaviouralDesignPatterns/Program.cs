using BehaviouralDesignPatterns.Observer.BadSln;

var dataSource = new DataSource();
var sheet2 = new Sheet2();
var barChart = new Barchart();

dataSource.AddDependents(sheet2);
dataSource.AddDependents(barChart);

dataSource.SetValues([5,10,15,20]);
dataSource.GetValues();