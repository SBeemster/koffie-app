import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppComponent } from "./app.component";
import { AppRoutingModule } from ".//app-routing.module";
import { CoreModule } from "./core/core.module";
import { NotFoundComponent } from "./modules/not-found/not-found.component";
import { SharedModule } from "./shared/shared.module";

@NgModule({
  declarations: [AppComponent, NotFoundComponent],
  imports: [BrowserModule, AppRoutingModule, CoreModule, SharedModule],
  bootstrap: [AppComponent]
})
export class AppModule {}
