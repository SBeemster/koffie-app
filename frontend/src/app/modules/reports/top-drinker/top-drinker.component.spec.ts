import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopDrinkerComponent } from './top-drinker.component';

describe('TopDrinkerComponent', () => {
  let component: TopDrinkerComponent;
  let fixture: ComponentFixture<TopDrinkerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopDrinkerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopDrinkerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
