import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TeamMember } from './teamMember';

@Injectable()
export class DataService {

  private url = "/api/teamMembers";

  constructor(private http: HttpClient) {
  }

  getTeamMembers() {
    return this.http.get(this.url);
  }

  getTeamMember(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createTeamMember(teamMember: TeamMember) {
    return this.http.post(this.url, teamMember);
  }

  updateTeamMember(teamMember: TeamMember) {

    return this.http.put(this.url, teamMember);
  }

  deleteTeamMember(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
