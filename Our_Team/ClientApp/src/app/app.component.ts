import { Component, OnInit  } from '@angular/core';
import { DataService } from './data.service';
import { TeamMember } from './teamMember';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [DataService]
})
export class AppComponent implements OnInit{
  title = 'app';


  teamMember: TeamMember = new TeamMember();
  teamMembers: TeamMember[];
  tableMode: boolean = true;

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadTeamMembers();
  }

  loadTeamMembers() {
    this.dataService.getTeamMembers()
      .subscribe((data: TeamMember[]) => this.teamMembers = data);
  }

  save() {
    if (this.teamMember.id == null) {
      this.dataService.createTeamMember(this.teamMember)
        .subscribe((data: TeamMember) => this.teamMembers.push(data));
    } else {
      this.dataService.updateTeamMember(this.teamMember)
        .subscribe(data => this.loadTeamMembers());
    }
    this.cancel();
  }
  editTeamMember(t: TeamMember) {
    this.teamMember = t;
  }
  cancel() {
    this.teamMember = new TeamMember();
    this.tableMode = true;
  }
  delete(t: TeamMember) {
    this.dataService.deleteTeamMember(t.id)
      .subscribe(data => this.loadTeamMembers());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }

}
