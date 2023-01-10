import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { FileService } from '../services/file.service';

@Component({
  selector: 'app-image-uploader',
  templateUrl: './image-uploader.component.html',
  styleUrls: ['./image-uploader.component.css']
})
export class ImageUploaderComponent {
  file: any;
  imageSrc: any;
  Text: string="";
  images:any=[];
  constructor(private fileservice:FileService,private router: Router){
    
  }
  
  
  async onUpload() {
    let formdata = new FormData();
    var name = this.file.name;
    formdata.append(this.Text, this.file, name)
    console.log(this.file);
    await this.fileservice.upload(formdata);
  }
  onChange(event: any) {
    this.file = event.target.files[0];
    const reader = new FileReader();
    reader.onload = (e) => {this.imageSrc = reader.result;}
    reader.readAsDataURL(this.file);
  }
  AllImages(){
    this.router.navigate(['/AllImages']);
  }

}
