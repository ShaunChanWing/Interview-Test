import { Component, OnInit } from '@angular/core';
import { Hero } from '../models/hero.model';
import { ApiService } from './service/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  heroes

  // styles = ['randcolor1', 'randcolor2', 'randcolor3', 'randcolor4']

  styles = ['randcolor1']

  constructor(private heroApiService : ApiService) {

    // get all heroes from the api
    this.heroApiService.getAllHeros().subscribe(apiheros => {

      this.heroes = apiheros

    });
  }

  ngOnInit() {

  }

  //post evolution

  evolve(hero){
    this.heroApiService.evolveHero(hero)
  }

  getRandomStyle(){
    return this.styles[Math.floor(Math.random() * this.styles.length)];

  }

}
