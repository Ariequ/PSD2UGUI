public class PSDUI
{
	public Layer[] layers;
    public Size psdSize;

	public enum LayerType { Normal, ScrollView, Grid, Button, Lable}
	public class Layer
	{
		public string name;
		public LayerType type;

        //行数
        //列数
        //render width
        //render height
        //水平间距
        //垂直间距
        //滑动方向
        public string[] arguments;   

		public Layer[] layers;
		public Image[] images;
		public Position position;
		public Size size;
	}

	public class Position
	{
		public float x;
		public float y;
	}

	public class Size
	{
		public float width;
		public float height;
	}

	public enum ImageType { Image, Texture, Label, SliceImage }; 
	public enum ImageSource { Common, Custom };

	public class Image
	{
		public ImageType imageType;
		public ImageSource imageSource;
		public string name;
		public Position position;
		public Size size;

        // Label color.rgb.hexValue font size  content
        // SliceImage left right bottom top
		public string[] arguments;    
	}
}


