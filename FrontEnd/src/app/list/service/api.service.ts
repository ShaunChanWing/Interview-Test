import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Hero } from 'src/app/models/hero.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http:HttpClient) { }


  getAllHeros(): Observable<Hero>{
    return this.http.get<Hero>(this.baseApiUrl + '/api/heroes')

  }

  evolveHero(heroName) {
    this.http.post(this.baseApiUrl + '/api/heroes',heroName)
  }
}
