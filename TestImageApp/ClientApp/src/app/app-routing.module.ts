import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ImageUploaderComponent } from './image-uploader/image-uploader.component';
import { ImagesGridComponent } from './images-grid/images-grid.component';

const routes: Routes = [
  { path: 'UploadImage', component: ImageUploaderComponent },
  { path: 'AllImages', component: ImagesGridComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
