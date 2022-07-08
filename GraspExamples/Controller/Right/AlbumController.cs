using System;

namespace GraspExamples.Controller.Right
{
    public class AlbumController
    {
        PhotoRepository _photoRepository;

        public AlbumController(PhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        internal void TagPhoto(string newTag)
        {
            Photo photo = _photoRepository.ReadPhoto();
            photo.AddTag(newTag);
            _photoRepository.UpdatePhoto(photo);
        }
    }
}