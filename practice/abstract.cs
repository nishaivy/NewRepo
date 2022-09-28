using System;
abstart class solid{
    public abstract double Volume();
    public abstract double SurfaceArea();
    public void Show(){
        MessageBox.Show('Volume:'+Volume());
        MessageBox.Show('SurfaceArea:'+SurfaceArea());
    }
}

// abstract class Solid
// {
// 	public abstract double Volume();
// 	public abstract double SurfaceArea();
// 	public void Show()
// 	{
// 		MessageBox.Show('Volume : ' + Volume());
// 		MessageBox.Show('Surface Area : ' + SurfaceArea());
// 	}
// }

// class Cube : Solid
// {
	

// }

// abstract class Cylinder : Solid
// {

// }
