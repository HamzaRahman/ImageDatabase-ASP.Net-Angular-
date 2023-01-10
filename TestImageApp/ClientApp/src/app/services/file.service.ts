import { Injectable } from '@angular/core';
import {HttpClient} from  '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class FileService {
  constructor(private http:HttpClient) { }
  async upload(data:any):Promise<any>{
      return this.http.post("https://localhost:44313/AddImage", data).toPromise();//.then((value)=>{console.log(value)})
  }
  async GetImages() {
    return this.http.get("https://localhost:44313/GetImages").toPromise();
  }
}
