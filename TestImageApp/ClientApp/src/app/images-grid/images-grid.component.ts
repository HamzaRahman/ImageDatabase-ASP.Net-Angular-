import { Component } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { FileService } from '../services/file.service';

@Component({
  selector: 'app-images-grid',
  templateUrl: './images-grid.component.html',
  styleUrls: ['./images-grid.component.css']
})
export class ImagesGridComponent {
  images: any=[];
  constructor(private fileservice:FileService,private sanitizer: DomSanitizer){
    this.getImages();
  }
  async getImages(){
    this.images=await this.fileservice.GetImages();
    
  }
  getImgSource(imageBin: any){
    let objectURL = 'data:image/png;base64,' + imageBin;
    return this.sanitizer.bypassSecurityTrustUrl(objectURL);
  }
}
