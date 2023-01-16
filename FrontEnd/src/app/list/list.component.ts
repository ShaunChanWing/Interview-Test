import { AnimationMetadataType } from '@angular/animations';
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

  name = null;
  power
  strenght
  intelligence
  stamina

  styles = ['randcolor1', 'randcolor2', 'randcolor3', 'randcolor4']

  // styles = ['randcolor1']

  constructor(private heroApiService : ApiService) {

    // get all heroes from the api
    this.getAllHeroes()

  }

  ngOnInit() {

  }
 // get all heroes from the api
  getAllHeroes(){
    this.heroApiService.getAllHeros().subscribe(apiheros => {

      this.heroes = apiheros

    });
  }

  addHero(){

    this.heroApiService.addHero(
      {
        "name" : this.name,
        "power" : this.power,
        "strength" : this.strenght,
        "intelligence" : this.intelligence,
        "stamina" : this.stamina
      }
    ).subscribe(apireturn => {
      this.getAllHeroes()
      this.name = null
    })

  }


  // evolution

  evolve(heroId){
    this.heroApiService.evolveHero(heroId).subscribe(apievolve => {
      // refresh heroes

      this.name = apievolve.name
      this.power = apievolve.power
      this.strenght = apievolve.strength
      this.intelligence = apievolve.intelligence
      this.stamina = apievolve.stamina


      this.getAllHeroes()

    })}

  getRandomStyle(){
    return this.styles[Math.floor(Math.random() * this.styles.length)];

  }
}
