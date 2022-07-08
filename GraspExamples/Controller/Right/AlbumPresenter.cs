using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.Controller.Right
{
    public class AlbumPresenter
    {

        AlbumController _controller;

        public AlbumPresenter(AlbumController controller)
        {
            _controller = controller;
        }

        public void TagAdded(string tag)
        {
            _controller.TagPhoto(tag);
        }

    }
}
