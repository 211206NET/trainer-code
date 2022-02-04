import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(private router:Router, private auth: AuthService) { }

  goToList(): void
  {
    this.router.navigate(['restaurants']);
  }

  user: any = {}

  ngOnInit(): void {
    this.auth.user$.subscribe((userInfo) => {
      this.user = userInfo;
    })
  }

}
