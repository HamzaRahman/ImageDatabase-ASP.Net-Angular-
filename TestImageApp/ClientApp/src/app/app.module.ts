import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ImageUploaderComponent } from './image-uploader/image-uploader.component';
import {HttpClientModule} from  '@angular/common/http';
import { FileService } from './services/file.service';
import { FormsModule } from '@angular/forms';
import { ImagesGridComponent } from './images-grid/images-grid.component';
@NgModule({
  declarations: [
    AppComponent,
    ImageUploaderComponent,
    ImagesGridComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule
  ],
  providers: [FileService],
  bootstrap: [AppComponent]
})
export class AppModule { }
