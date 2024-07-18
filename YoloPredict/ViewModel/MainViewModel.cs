using Ookii.Dialogs.Wpf;
using YoloPredict.Common;
using YoloPredict.Model;

namespace YoloPredict.ViewModel;

public class MainViewModel
{
    public MainModel MainModel { get; set; }

    public CommandBase OpenFolderCommand { get; set; }

    public MainViewModel()
    {
        MainModel = new MainModel
        {
            ClassNum = "1",
            ImgWidth = "11",
            ImgHeight = "22",
            Confidence = "0.6",
            ModelPath = "111111",
            NmsValue = "0",
            InferMessage = ""
        };
        OpenFolderCommand = new CommandBase(DoOpenFolder(), DoCanExecute());
    }
    
    private Action<object> DoOpenFolder()
    {
        return obj =>
        {
            VistaFolderBrowserDialog folderDialog = new()
            {
                Description = "请选择一个文件夹",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() != true) return;
            
            
        };
    }

    private Func<object, bool> DoCanExecute()
    {
        return obj => true;
    }
}