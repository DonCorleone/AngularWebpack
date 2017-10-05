import { Component, OnInit } from '@angular/core';
import dataset from '../../data/links';

@Component({
  selector: 'app-links-list',
  templateUrl: './links.component.html',
  styleUrls: ['./links.component.scss']
})
export class LinksComponent implements OnInit {

  links = dataset.links;
  constructor() { }

  ngOnInit() {
  }
}
