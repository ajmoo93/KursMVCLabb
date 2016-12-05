﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCLabbData.Entities;

namespace MVCLabbData.Repositories
{
    public class CommentRepository
    {
        public void AddNewPhotoComment(Guid photoid,CommentsEntityModel newphotoComment)
        {
            using (var context =new MVCLabbRepositoryDbContext())
            {
                var photoentity = context.PhotoEntityModels.FirstOrDefault(p => p.PhotoId == photoid);
                photoentity.Comment.Add(newphotoComment);
                context.SaveChanges();
            }
        }
        public void AddNewAlbumComment(Guid albumid,CommentsEntityModel newalbumCommet)
        {
            using (var context = new MVCLabbRepositoryDbContext())
            {
                var albumentity = context.AlbumEntityModels.FirstOrDefault(a => a.AlbumId == albumid);
                albumentity.Comment.Add(newalbumCommet);
                context.SaveChanges();
            }
        }
    }
}
