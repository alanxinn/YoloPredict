using System.ComponentModel;
using System.Windows.Media.Imaging;
using YoloPredict.Common;

namespace YoloPredict.Model;

public class MainModel : NotifyBase
{
    private BitmapImage _imageShow;

    public BitmapImage ImageShow
    {
        get => _imageShow;
        set
        {
            _imageShow = value;
            OnPropertyChanged();
        }
    }

    private string _modelPath;

    public string ModelPath
    {
        get => _modelPath;
        set
        {
            _modelPath = value;
            OnPropertyChanged();
        }
    }

    private string _imgWidth;

    public string ImgWidth
    {
        get => _imgWidth;
        set
        {
            _imgWidth = value;
            OnPropertyChanged();
        }
    }

    private string _imgHeight;

    public string ImgHeight
    {
        get => _imgHeight;
        set
        {
            _imgHeight = value;
            OnPropertyChanged();
        }
    }

    private string _classNum;

    public string ClassNum
    {
        get => _classNum;
        set
        {
            _classNum = value;
            OnPropertyChanged();
        }
    }

    private string _confidence;

    public string Confidence
    {
        get => _confidence;
        set
        {
            _confidence = value;
            OnPropertyChanged();
        }
    }

    private string _nmsValue;

    public string NmsValue
    {
        get => _nmsValue;
        set
        {
            _nmsValue = value;
            OnPropertyChanged();
        }
    }

    private string _inferMessage;

    public string InferMessage
    {
        get { return _inferMessage; }
        set
        {
            _inferMessage = value;
            OnPropertyChanged();
        }
    }
}