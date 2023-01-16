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

  evolveHero(heroId) {
    return this.http.put<Hero>(this.baseApiUrl + '/api/heroes/' + heroId ,'')

  }

  addHero(heroInfo) {

    // console.log(heroInfo)

    return this.http.post<Hero>(this.baseApiUrl + '/api/heroes',heroInfo)

  }
}
