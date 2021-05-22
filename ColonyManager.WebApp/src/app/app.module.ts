import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './blocks/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { authInterceptorProviders } from './interceptors/auth.interceptor';
import { FooterComponent } from './blocks/footer/footer.component';
import { HeaderComponent } from './blocks/header/header.component';
import { loaderInterceptorProviders } from './interceptors/loader.interceptor';
import { LoaderService } from './services/loader.service';
import { SharedModule } from './blocks/shared.module';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { UserEffects } from './store/effects/app.effect';
import { AllReducersModule } from './store/reducers/store.reducers.module';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { environment } from 'src/environments/environment';
import { ComponentsModule } from './components/components.module';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    FooterComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    SharedModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ComponentsModule,
    StoreModule.forRoot({}),
    StoreDevtoolsModule.instrument({
      maxAge: 25,
      logOnly: !environment.production,
    }),
    AllReducersModule,
    AppRoutingModule,
    EffectsModule.forRoot([UserEffects]),
  ],
  providers: [
    LoaderService,
    authInterceptorProviders,
    loaderInterceptorProviders,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
