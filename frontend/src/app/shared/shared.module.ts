import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { MenuComponent } from './menu/menu.component';
import { LogoutComponent } from './header/logout/logout.component';
import { GroupComponent } from './header/group/group.component';

@NgModule({
  imports: [CommonModule, RouterModule],
  declarations: [HeaderComponent, FooterComponent, MenuComponent, LogoutComponent, GroupComponent],
  exports: [HeaderComponent, FooterComponent, MenuComponent]
})
export class SharedModule {}
